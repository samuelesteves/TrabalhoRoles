using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoRole.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Ramo { get; set; }

        [ForeignKey("Produto")]
        public int IdProuto { get; set; }

        public virtual Produto? Produto { get; set; }
    }
}
