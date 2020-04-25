using System.ComponentModel.DataAnnotations;

namespace PrimerParcialPrograAplicada.Models
{
    public enum TypeList
    {
        Leonardo,
        Callau,
        Rodriguez,
    }
    public class callau
    {
        [Key]
        public int CallauID { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        [StringLength(24, MinimumLength = 2)]
        public string Friendof { get; set; }
        [Required]
        public TypeList Place { get; set; }
        [EmailAddressAttribute]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public int Birthdate { get; set; }
    }
}