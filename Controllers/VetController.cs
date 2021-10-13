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
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Practica_2.Models;
using Practica_2.ViewModels;
namespace Practica_2.Controllers
{
    public class VetController : Controller
    {
        public List<Veterinaria> listVeterinaria = null;
        public List<Noticias> listNoticias = null;
        private AppDbContext _context;
        public VetController(AppDbContext context)
        {
            _context = context;
            /*var jsonString = System.IO.File.ReadAllText("Models/Veterinaria.json");
            listVeterinaria = JsonConvert.DeserializeObject<List<Veterinaria>>(jsonString);*/
            var jsonString = System.IO.File.ReadAllText("Models/Noticias.json");
            listNoticias = JsonConvert.DeserializeObject<List<Noticias>>(jsonString);
        }


        public IActionResult Agregar()
        {
            return View(new Veterinaria());
        }
        [HttpPost]
        public async Task<IActionResult> Guardar(Veterinaria model)
        {
            if (ModelState.IsValid)
            {
                _context.Veterinarias.Add(model);
                await _context.SaveChangesAsync();
                return View("Index", await _context.Veterinarias.ToListAsync());
            }
            return View("Agregar", model);
        }

        public async Task<IActionResult> Index()
        {
            var veter = await _context.Veterinarias.ToListAsync();
            return View(veter);
        }

        public async Task<IActionResult> Details(int Id)
        {
            var veter = await _context.Veterinarias.FindAsync(Id);

            VeterinariaNoticiasViewModel vnvm = new VeterinariaNoticiasViewModel();
            vnvm.Veterinaria = veter;
            vnvm.ListNoticias = listNoticias;
            return View(vnvm);
        }
        public IActionResult Find(string producto)
        {
            List<Veterinaria> listVet = new List<Veterinaria>();
            bool enc = false;
            foreach (var item in listVeterinaria)
            {
                if (item.Nombre.ToLower().Contains(producto.ToLower()))
                {
                    enc = true;
                    listVet.Add(item);
                }
            }
            if (enc == true)
            {
                return View("Index", listVet);
            }
            else
            {
                ViewData["Message"] = "La búsqueda no coincide con ninguno de nuestros productos";
                return View("Notification");
            }
        }
        public async Task<IActionResult> Delete(int id){
            var veter = await _context.Veterinarias.FindAsync(id);
            if(veter == null){
                return NotFound();
            }
            _context.Remove(veter);
            await _context.SaveChangesAsync();
            return View("Index", await _context.Veterinarias.ToListAsync());
        }
    }
}