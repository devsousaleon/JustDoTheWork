using System.Data;
using System.Globalization;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;

namespace JustDoTheWork.Sistema.Services;

public static class ImpressaoHistoricoService
{
    private static readonly CultureInfo Cultura = CultureInfo.GetCultureInfo("pt-BR");

    public static string GerarDocumento(DadosImpressaoHistoricoDTO dados)
    {
        if (dados.Modelo.Texto is not { Length: > 0 } || dados.Registros.Count == 0)
            throw new InvalidOperationException("O relatório precisa de um modelo com texto e de execuções para impressão.");

        using var modelo = new RichEditDocumentServer();
        modelo.LoadDocument(dados.Modelo.Texto, DocumentFormat.OpenXml);
        using var fonte = new DataTable();
        var dataHoraImpressao = DateTime.Now;

        foreach (var registro in dados.Registros)
        {
            var valores = CriaValores(dados, registro, dataHoraImpressao);
            if (fonte.Columns.Count == 0)
                foreach (var campo in valores.Keys)
                    fonte.Columns.Add(campo, typeof(string));

            var linha = fonte.NewRow();
            foreach (var campo in valores)
                linha[campo.Key] = campo.Value;

            using var fonteRegistro = fonte.Clone();
            fonteRegistro.Rows.Add(linha.ItemArray);

            // Conteúdos armazenados em OpenXML viram texto, nunca a representação de um byte[].
            // A própria referência de conteúdo fica vazia nesta avaliação para evitar recursão.
            linha["Atividade.Descricao"] = ExtraiTextoPreenchido(registro.Atividade.Descricao, fonteRegistro);
            fonteRegistro.Rows[0]["Atividade.Descricao"] = linha["Atividade.Descricao"];
            linha["ModeloRelatorio.Texto"] = ExtraiTextoPreenchido(dados.Modelo.Texto, fonteRegistro);
            fonte.Rows.Add(linha);
        }

        ValidaCampos(modelo, fonte);
        using var resultado = new RichEditDocumentServer();
        var opcoes = modelo.CreateMailMergeOptions();
        opcoes.DataSource = fonte;
        opcoes.MergeMode = MergeMode.NewSection;
        opcoes.HeaderFooterLinkToPrevious = false;
        modelo.MailMerge(opcoes, resultado.Document);
        return resultado.RtfText;
    }

    private static Dictionary<string, string> CriaValores(DadosImpressaoHistoricoDTO dados, RegistroImpressaoHistoricoDTO registro, DateTime dataHoraImpressao)
        => new()
        {
            ["Atividade.Id"] = Formata(registro.Atividade.Id),
            ["Atividade.Nome"] = registro.Atividade.Nome ?? string.Empty,
            ["Atividade.Descricao"] = string.Empty,
            ["Atividade.Status"] = registro.Atividade.Status == StatusAtividade.Analise ? "Análise" : registro.Atividade.Status.ToString(),
            ["Atividade.DataCriacao"] = Formata(registro.Atividade.DataCriacao),
            ["Atividade.DataFinalizacao"] = Formata(registro.Atividade.DataFinalizacao),
            ["Atividade.ProjetoId"] = Formata(registro.Atividade.ProjetoId),
            ["Execucao.Id"] = Formata(registro.Execucao.Id),
            ["Execucao.DataInicio"] = Formata(registro.Execucao.DataInicio),
            ["Execucao.DataFim"] = Formata(registro.Execucao.DataFim),
            ["Execucao.AtividadeId"] = Formata(registro.Execucao.AtividadeId),
            ["Projeto.Id"] = Formata(registro.Projeto.Id),
            ["Projeto.Nome"] = registro.Projeto.Nome ?? string.Empty,
            ["ModeloRelatorio.Id"] = Formata(dados.Modelo.Id),
            ["ModeloRelatorio.Descricao"] = dados.Modelo.Descricao ?? string.Empty,
            ["ModeloRelatorio.TipoModeloId"] = Formata(dados.Modelo.TipoModeloId),
            ["ModeloRelatorio.Texto"] = string.Empty,
            ["ModeloRelatorio.Ativo"] = dados.Modelo.Ativo ? "Sim" : "Não",
            ["TipoModelo.Id"] = Formata(dados.TipoModelo.Id),
            ["TipoModelo.Descricao"] = dados.TipoModelo.Descricao ?? string.Empty,
            ["Usuario.Id"] = Formata(dados.Usuario?.Id),
            ["Usuario.Nome"] = dados.Usuario?.Nome ?? string.Empty,
            ["Usuario.Logon"] = dados.Usuario?.Logon ?? string.Empty,
            ["Usuario.TipoUsuarioId"] = Formata(dados.Usuario?.TipoUsuarioId),
            ["TipoUsuario.Id"] = Formata(dados.TipoUsuario?.Id),
            ["TipoUsuario.Tipo"] = dados.TipoUsuario?.Tipo ?? string.Empty,
            ["Comum.Data"] = dataHoraImpressao.ToString("dd/MM/yyyy", Cultura),
            ["Comum.Hora"] = dataHoraImpressao.ToString("HH:mm:ss", Cultura),
            ["Comum.DataHora"] = Formata(dataHoraImpressao),
            ["Comum.DataPorExtenso"] = dataHoraImpressao.ToString("d 'de' MMMM 'de' yyyy", Cultura),
            ["Comum.DiaDaSemana"] = dataHoraImpressao.ToString("dddd", Cultura)
        };

    private static string Formata(object valor)
        => valor switch
        {
            null => string.Empty,
            DateTime data => data.ToString("dd/MM/yyyy HH:mm:ss", Cultura),
            _ => Convert.ToString(valor, Cultura) ?? string.Empty
        };

    private static string ExtraiTextoPreenchido(byte[] conteudo, DataTable fonte)
    {
        if (conteudo is not { Length: > 0 })
            return string.Empty;

        using var documento = new RichEditDocumentServer();
        documento.LoadDocument(conteudo, DocumentFormat.OpenXml);
        ValidaCampos(documento, fonte);
        using var resultado = new RichEditDocumentServer();
        var opcoes = documento.CreateMailMergeOptions();
        opcoes.DataSource = fonte;
        documento.MailMerge(opcoes, resultado.Document);
        return resultado.Text.TrimEnd('\r', '\n');
    }

    private static void ValidaCampos(RichEditDocumentServer documento, DataTable fonte)
    {
        foreach (var campo in documento.Document.Fields.GetMergeFieldNames())
            if (!fonte.Columns.Contains(campo))
                throw new InvalidOperationException($"O campo objeto '{campo}' não está disponível para impressão. Revise o modelo do relatório.");
    }
}
