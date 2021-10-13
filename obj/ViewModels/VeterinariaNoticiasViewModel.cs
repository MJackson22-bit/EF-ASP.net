using System.Collections.Generic;
using Practica_2.Models;
namespace Practica_2.ViewModels
{
    public class VeterinariaNoticiasViewModel
    {
        public Veterinaria Veterinaria { get; set; }
        public List<Noticias> ListNoticias { get; set; }
    }
}