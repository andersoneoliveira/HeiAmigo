using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeiAmigo.Models;
using Microsoft.AspNetCore.Mvc;

namespace HeiAmigo.Controllers
{
    public class EstabsController : Controller
    {
        public IActionResult Index()
        {
            List<Estab> list = new List<Estab>();
            /*vou inserir alguns registros manualmente para auxiliar na implementação*/
            list.Add(new Estab { Id = 1, RazaoSocial = "Fulanos", NomeFantasia = "Fulanos" });
            list.Add(new Estab { Id = 2, RazaoSocial = "Golfinhos", NomeFantasia = "Golfinhos" });
            list.Add(new Estab { Id = 3, RazaoSocial = "Praiano", NomeFantasia = "Praiano" });

            return View(list);
        }
    }
}