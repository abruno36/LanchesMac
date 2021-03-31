using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        [Display(Name = "Descrição Curta")]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        [Display(Name = "Descrição Detalhada")]
        public string DescricaoDetalhada { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Preco { get; set; }
        [StringLength(200)]
        [Display(Name = "Imagem url")]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        [Display(Name = "Imagem url")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Produto Preferido")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Em Estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
