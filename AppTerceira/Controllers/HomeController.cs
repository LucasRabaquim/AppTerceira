using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using AppTerceira.Models;

namespace AppTerceira.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Fisica pf = new Fisica
            {
                Id = 2,
                Nome = "Roberta",
                Sexo = 'F',
                CPF = 12345678911,
                RG = 12345678,
                Dig_RG = '9'
            };
            return View(pf);
        }

        public ActionResult About()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 12;
            pessoa.Nome = "Enildo";
            pessoa.Sexo = 'F';
            return View(pessoa);
        }

        public ActionResult Contact()
        {
            Juridica pj = new Juridica();
            pj.Id = 1001;
            pj.Nome = "Fábrica de Gênios";
            pj.Cnpj = 12345789123412;
            pj.IE = 123456789;

            return View(pj);
        }

        public ActionResult ExemploTempData()
        {
            Juridica pj = new Juridica();
           
            pj.Id = 256;
            pj.Nome = "Desenvolvedores CIA";
            pj.Cnpj = 12345789188888;
            pj.IE = 123499999;

            TempData["Id"] = pj.Id;
            TempData["Nome"] = pj.Nome;
            TempData["Cnpj"] = pj.Cnpj;
            TempData["IE"] = pj.IE;

            return RedirectToAction("Contact");
        }

       /* public ActionResult Pesoa()
        {
            Fisica pf = new Fisica
            {
                Id = 2,
                Nome = "Roberta",
                Sexo = 'F',
                CPF = 12345678911,
                RG = 12345678,
                Dig_RG = '9'
            };
            return View(pf);
        }*/
    }
}