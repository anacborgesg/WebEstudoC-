using System.ComponentModel.DataAnnotations;
using WebEstudo.Models.Enum;

namespace WebEstudo.Models
{
    public class Sale
    {
        [Key]
        [Display(Name = "Nº")]
        public int Id { get; set; }
        public Client? Client { get; set; }
        [Display(Name = "Selecione o cliente")]
        public int ClientId { get; set; }

        [Display(Name = "Nome do produto")]
        public string? NameProduct { get; set; }

        [Display(Name = "Categoria")]
        public EnumProd Category { get; set; }

        [Display(Name = "Valor da compra")]
        public double SaleValue { get; set; }

        [Display(Name = "Dia da compra")]
        public DateTime DateOfSale { get; set; }

        [Display(Name = "Ativo?")]
        public bool Active { get; set; }
    }
}
