using DevExpress.XtraEditors;
using JustDoTheWork.Controller;

namespace JustDoTheWork.UI.Core
{
    public static class UIMethodsService
    {
        public static void AtualizaComboBoxProjeto(ProjetoController _projetoController, LookUpEdit comboProjeto)
        {
            var dados = _projetoController.PesquisarParaCombo().ToList();

            if (dados == null)
                return;

            comboProjeto.Properties.DataSource = dados;
            comboProjeto.Properties.DisplayMember = "Nome";
            comboProjeto.Properties.ValueMember = "Id";
            comboProjeto.Properties.NullText = "Selecione um projeto";
        }

        public static void AtualizaComboBoxStatus(AtividadeController _atividadeController, LookUpEdit comboStatus)
        {
            comboStatus.Properties.DataSource = _atividadeController.ObterStatusAtividade();

            comboStatus.Properties.DisplayMember = "Status";
            comboStatus.Properties.ValueMember = "Id";
            comboStatus.Properties.NullText = "Selecione uma opção";
        }

        public static void AtualizaComboBoxTipoModelo(TipoModeloController _tipoModeloController, LookUpEdit comboTipoModelo)
        {
            var resultadoBusca = _tipoModeloController.PesquisarParaCombo().ToList();

            if (resultadoBusca == null)
                return;

            comboTipoModelo.Properties.DataSource = resultadoBusca;
            comboTipoModelo.Properties.DisplayMember = "Descricao";
            comboTipoModelo.Properties.ValueMember = "Id";
            comboTipoModelo.Properties.NullText = "Selecione um modelo";
        }
    }
}