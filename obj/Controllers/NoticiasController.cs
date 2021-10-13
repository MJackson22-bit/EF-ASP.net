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
    public class NoticiasController : Controller
    {
        public List<Noticias> listNoticias = null;
        public NoticiasController()
        {
            var jsonString = System.IO.File.ReadAllText("Models/Noticias.json");
            listNoticias = JsonConvert.DeserializeObject<List<Noticias>>(jsonString);
        }

        public IActionResult Index(int id)
        {
            return PartialView("~/Views/Vet/Noticias.cshtml", listNoticias);
        }
    }
}