using System.ComponentModel.DataAnnotations.Schema;

namespace ProcAccess.Models
{
    [Table("tbCategoria")]
    public class Categoria
    {
        public int CategoriaId { get; set; }
       
        public string Descricao { get; set; } 
    }
}
