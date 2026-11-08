using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Controller
{
    public class AtividadeController
    {
        private readonly IAtividadeRepository _atividadeRepository;
        private readonly UsuarioSessaoDTO? _usuario;

        public AtividadeController(IAtividadeRepository repository, JustDoTheWorkDbContextFactory dbContextFactory, UsuarioSessaoDTO? usuario = null)
        {
            _atividadeRepository = repository;
            _usuario = usuario;
        }

        public bool PodeCadastrar => _usuario != null && (_usuario.EhTechLead || string.Equals(_usuario.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase));

        public bool PodeMovimentar(Atividade atividade)
            => ConsultaAtividade.PodeMovimentar(atividade, _usuario);

        public bool PodeEditar(Atividade atividade) => ConsultaAtividade.PodeEditar(atividade, _usuario);
        public bool PodeCancelar(Atividade atividade) => ConsultaAtividade.PodeCancelar(atividade, _usuario);
        public bool PodeAssumir(Atividade atividade) => ConsultaAtividade.PodeAssumir(atividade, _usuario);
        public bool PodeExcluir(AtividadeDTO atividade)
            => (_usuario?.EhTechLead == true || (_usuario?.Id == atividade.UsuarioResponsavelId &&
                string.Equals(_usuario?.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase))) &&
               atividade.Etapa == EtapaAtividade.Historiador && atividade.Status is StatusAtividade.Pendente or StatusAtividade.Analise && !atividade.TemExecucoes;

        public string Inclusao(AtividadeDTO atividadeDTO)
        {
            if (!PodeCadastrar)
                return "Somente o Historiador ou o Tech Lead pode cadastrar atividades.";
            var mensagem = ValidarDados(atividadeDTO);
            if (mensagem != "")
                return mensagem;
            if (_usuario?.EhTechLead != true)
                atividadeDTO.UsuarioResponsavelId = _usuario!.Id;
            var atividade = new Atividade
            {
                Nome = atividadeDTO.Nome.Trim(),
                Descricao = atividadeDTO.Descricao,
                ProjetoId = atividadeDTO.ProjetoId,
                UsuarioResponsavelId = atividadeDTO.UsuarioResponsavelId,
                DataCriacao = RelogioAplicacao.Agora
            };
            mensagem = _atividadeRepository.Inclusao(atividade);
            if (mensagem == "")
                atividadeDTO.Id = atividade.Id;
            return mensagem;
        }

        public IEnumerable<StatusDTO> ObterStatusAtividade()
            => Enum.GetValues<StatusAtividade>().Select(status => new StatusDTO { Id = (int)status, Status = status.ToString() });

        public string Exclusao(AtividadeDTO atividade)
            => _atividadeRepository.ExclusaoPorId(atividade);

        public string Edicao(AtividadeDTO atividadeDTO, int statusAtual)
        {
            var mensagem = ValidarDados(atividadeDTO);
            if (mensagem != "")
                return mensagem;
            return _atividadeRepository.Edicao(atividadeDTO);
        }

        public string AvancarAtividade(AtividadeDTO atividadeDTO, int? usuarioDestinoId = null)
        {
            var mensagem = ValidarDados(atividadeDTO);
            if (mensagem != "")
                return mensagem;
            if (!DocumentoAtividade.TemConteudo(atividadeDTO.Descricao))
                return "É necessário informar os requisitos da atividade antes de avançar.";
            return _atividadeRepository.AvancarAtividade(atividadeDTO, usuarioDestinoId);
        }

        public string CancelarAtividade(AtividadeDTO atividadeDTO)
            => _atividadeRepository.CancelarAtividade(atividadeDTO);

        public string DevolverDesenvolvedor(AtividadeDTO atividadeDTO)
        {
            var mensagem = ValidarDados(atividadeDTO);
            return mensagem == "" ? _atividadeRepository.DevolverDesenvolvedor(atividadeDTO) : mensagem;
        }

        public string VincularResponsavel(AtividadeDTO atividade, int usuarioResponsavelId)
            => _atividadeRepository.VincularResponsavel(atividade, usuarioResponsavelId);

        public IEnumerable<ResultadoPesquisaAtividadeDTO> Pesquisar(FiltroPesquisaAtividadeDTO filtro)
            => _atividadeRepository.Pesquisar(filtro);

        public AtividadeDTO BuscarPorId(int id)
            => _atividadeRepository.BuscarPorId(id);

        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarHistorico(FiltroPesquisaHistoricoDTO filtro)
            => _atividadeRepository.PesquisarHistorico(filtro);

        public IEnumerable<ResultadoPesquisaAtividadeDTO> PesquisarPorStatus(params int[] status)
            => _atividadeRepository.PesquisarPorStatus(status);

        public string AlterarStatus(AtividadeDTO atividade, int novoStatus)
        {
            if (!FluxoAtividade.TransicaoPermitida(atividade.Status, (StatusAtividade)novoStatus))
                return "Essa ação não é permitida. Use Avançar etapa para encaminhar ou finalizar a atividade.";
            return _atividadeRepository.AlterarStatus(atividade, novoStatus);
        }

        private static string ValidarDados(AtividadeDTO? atividade)
        {
            if (atividade == null)
                return "Dados inválidos para a atividade.";
            if (string.IsNullOrWhiteSpace(atividade.Nome))
                return "É necessário informar o nome da atividade.";
            if (atividade.Nome.Length > 50)
                return "O nome da atividade deve ter até 50 caracteres.";
            if (atividade.ProjetoId is not > 0)
                return "É necessário vincular a atividade a um projeto.";
            if (atividade.Descricao is { Length: > 10 * 1024 * 1024 })
                return "A descrição excede o limite de 10 MiB.";
            return "";
        }
    }
}
