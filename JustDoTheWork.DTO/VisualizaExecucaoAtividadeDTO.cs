namespace JustDoTheWork.DTO
{
    public class VisualizaExecucaoAtividadeDTO
    {
        public string NomeAtividade { get; set; }
        public string NomeProjeto { get; set; }
        public byte[] DescricaoAtividade { get; set; }
        public DateTime DataCriacaoAtividade { get; set; }
    }
}