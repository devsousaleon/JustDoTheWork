namespace JustDoTheWork.Entity.DatabaseClasses
{
    public class Usuario : BaseClass
    {
        public string Nome { get; set; }
        public string Logon { get; set; }
        public string Senha { get; set; }
        public int TipoUsuarioId {  get; set; }
    }
}
