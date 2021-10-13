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
        public string Modo{get; set;}
        public string Aplicabilidad{get; set;}
         [Required]
        [Display(Name = "Foemulación")]
        public string Formulacion{get; set;}
       
        public string Indicaciones{get; set;}
        public string DosisAdm{get; set;}
        public string Presentacion{get; set;}
        [Display(Name = "Upload File")]
        [DataType(DataType.Upload)]
        public string Image{get; set;}
        public string ImageDetail{get; set;}
    }
}