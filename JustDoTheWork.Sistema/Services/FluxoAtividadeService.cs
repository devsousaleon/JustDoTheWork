using JustDoTheWork.Controller;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Sistema.Forms;
using JustDoTheWork.UI.Core.Geral;

namespace JustDoTheWork.Sistema.Services
{
    internal static class FluxoAtividadeService
    {
        public static bool AvancarAtividade(AtividadeController controller, AtividadeDTO atividade, IWin32Window dono)
        {
            if (!controller.PodeMovimentar(atividade))
            {
                MessageService.Atencao("Somente o responsável pela etapa atual pode avançar esta atividade.");
                return false;
            }
            var etapa = FluxoAtividade.ProximaEtapa(atividade.Etapa);
            int? destinoId = null;
            if (etapa != EtapaAtividade.Finalizada)
            {
                destinoId = FormSelecionaResponsavel.Selecionar(dono, FluxoAtividade.TipoUsuarioPorEtapa(etapa));
                if (!destinoId.HasValue)
                    return false;
            }
            var mensagem = controller.AvancarAtividade(atividade, destinoId);
            if (!string.IsNullOrWhiteSpace(mensagem))
            {
                MessageService.Atencao(mensagem);
                return false;
            }
            MessageService.Sucesso(etapa == EtapaAtividade.Finalizada ? "Atividade finalizada pelo QA Tester." : "Atividade encaminhada para " + FluxoAtividade.NomeEtapa(etapa) + ".");
            return true;
        }
    }
}
