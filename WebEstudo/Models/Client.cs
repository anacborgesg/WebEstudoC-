using System.ComponentModel.DataAnnotations;
using WebEstudo.Models.Enum;

namespace WebEstudo.Models
{
    public class Client
    {
        [Key]
        [Display(Name = "Nº")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Nome Completo")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Data de nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Tipo Documento")]
        public EnumDoc TypeDoc { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Documento")]
        public int Document { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Endereço")]
        public string? Adress { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Data de Cadastro")]
        public DateTime DateRegister { get; set; }

        [Display(Name = "Cliente ativo?")]
        public bool Active { get; set; }
    }
}
