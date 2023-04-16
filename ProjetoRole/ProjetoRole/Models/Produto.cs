using System.ComponentModel.DataAnnotations;

namespace ProjetoRole.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        public string? NomeProduto { get; set; }

        public double PrecoProduto { get; set; }
    }
}
