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
using Microsoft.AspNetCore.Authorization;
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
            listVeterinaria = JsonConvert.DeserializeObject<List<Veterinaria>>(jsonString);
            var jsonString = System.IO.File.ReadAllText("Models/Noticias.json");
            listNoticias = JsonConvert.DeserializeObject<List<Noticias>>(jsonString);*/
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin_Edit_Del")]
        public async Task<IActionResult> Editar(int? Id, Veterinaria model){
            if(Id == null){
                return NotFound();
            }
            if(ModelState.IsValid){
                try{
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                    return View("Index", await _context.Veterinarias.ToListAsync());
                }catch(DbUpdateConcurrencyException){
                    throw;
                }
            }
            return View("Editar", model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin_Edit_Del")]
        public async Task<IActionResult> Editar(int? Id){
            if(Id == null){
                return NotFound();
            }
            var veter = await _context.Veterinarias.FindAsync(Id);
            if(veter == null){
                return NotFound();
            }
            return View(veter);
        }
        [Authorize(Roles = "Admin_Agregar")]
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
            var veter = await _context.Veterinarias.Where(x => x.Id == Id).Include(x => x.Noticias).FirstAsync();
            return View(veter);
        }
        public async Task<IActionResult> Find(string producto)
        {
            List<Veterinaria> listVet = new List<Veterinaria>();
            var veter = await _context.Veterinarias.ToListAsync();
            bool enc = false;
            foreach (var item in veter)
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
        [Authorize(Roles = "Admin_Edit_Del")]
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