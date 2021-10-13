using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Practica_2.Models;
using Practica_2.ViewModels;
namespace Practica_2.Controllers
{
    public class VetController : Controller
    {
        public List<Veterinaria> listVeterinaria = null;
        public List<Noticias> listNoticias = null;
        public VetController()
        {
            var jsonString = System.IO.File.ReadAllText("Models/Veterinaria.json");
            listVeterinaria = JsonConvert.DeserializeObject<List<Veterinaria>>(jsonString);
            jsonString = System.IO.File.ReadAllText("Models/Noticias.json");
            listNoticias = JsonConvert.DeserializeObject<List<Noticias>>(jsonString);
        }


        public IActionResult Agregar()
        {
            return View(new Veterinaria());
        }
        public IActionResult Guardar(Veterinaria model)
        {
            if(ModelState.IsValid){
                
            }
            return View("Agregar", model);
        }   

        public IActionResult Index()
        {
            return View(listVeterinaria);
        }

        public IActionResult Details(int Id){
            VeterinariaNoticiasViewModel vnvm = new VeterinariaNoticiasViewModel();
            foreach (var item in listVeterinaria)
            {
                if(item.Id == Id){
                    vnvm.Veterinaria = item;
                    vnvm.ListNoticias = listNoticias;
                    return View(vnvm);
                }
            }
            return View(vnvm);
        }
        public IActionResult Find(string producto){
            List<Veterinaria> listVet = new List<Veterinaria>();
            bool enc = false;
            foreach (var item in listVeterinaria)
            {
                if(item.Nombre.ToLower().Contains(producto.ToLower())){
                    enc = true;
                    listVet.Add(item);
                }
            }
            if(enc == true){
                return View("Index", listVet);
            }else{
                ViewData["Message"] = "La búsqueda no coincide con ninguno de nuestros productos";
                return View("Notification");
            }
        }
    }
}