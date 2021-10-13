using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
namespace Practica_2.Models
{
    public class Veterinaria
    {
        public int Id{get; set;}
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre{get; set;}

        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion{get; set;}

        [Required]
        [Display(Name = "Modo")]
        public string Modo{get; set;}

        [Required]
        [Display(Name = "Aplicabilidad")]
        public string Aplicabilidad{get; set;}

        [Required]
        [Display(Name = "Formulación")]
        public string Formulacion{get; set;}
       
        [Required]
        [Display(Name = "Indicaciones")]
        public string Indicaciones{get; set;}

        [Required]
        [Display(Name = "DosisAdm")]
        public string DosisAdm{get; set;}

        [Required]
        [Display(Name = "Presentacion")]
        public string Presentacion{get; set;}

        [NotMapped]
        public string Images { get; set; }

        [Display(Name = "Imagenes en Json")]
        [Colum(TypeName = "json")]
        public string ImageJson { get; set;}
    }
}