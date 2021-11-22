namespace ProcAccess.Models
{
    public class Processo
    {
        public int ProcessoId { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
