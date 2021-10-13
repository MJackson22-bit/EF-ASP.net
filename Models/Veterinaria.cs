using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Collections.Generic;
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
<<<<<<< HEAD
    
        [Required]
        [Display(Name = "Modo")]
=======
>>>>>>> 134c422235d48d447e450f6894aa867229f4383b
        public string Modo{get; set;}
        public string Aplicabilidad{get; set;}
         [Required]
<<<<<<< HEAD
        [Display(Name = "Formulación")]
        public string Formulacion{get; set;}
        [Required]
        [Display(Name = "Indicaciones")]
        public string Indicaciones{get; set;}
        [Required]
        [Display(Name = "Dosis Administrativa")]

        public string DosisAdm{get; set;}

        [Required]
        [Display(Name = "Presentación")]
        public string Presentacion{get; set;}
        [Required]
        [Display(Name = "Image Presentación")]
        public string Image{get; set;}
        [Required]
        [Display(Name = "Image Detalle")]
        public string ImageDetail{get; set;}

        

=======
        [Display(Name = "Foemulación")]
        public string Formulacion{get; set;}
       
        public string Indicaciones{get; set;}
        public string DosisAdm{get; set;}
        public string Presentacion{get; set;}
        [Display(Name = "Upload File")]
        [DataType(DataType.Upload)]
        public string Image{get; set;}
        public string ImageDetail{get; set;}
>>>>>>> 134c422235d48d447e450f6894aa867229f4383b
    }
}