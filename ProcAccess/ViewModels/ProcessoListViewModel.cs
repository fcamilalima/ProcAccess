using ProcAccess.Models;

namespace ProcAccess.ViewModels
{
    public class ProcessoListViewModel
    {
        public IEnumerable<Processo> Processos { get; set; }

        public string Categorias = "Categorias";
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
