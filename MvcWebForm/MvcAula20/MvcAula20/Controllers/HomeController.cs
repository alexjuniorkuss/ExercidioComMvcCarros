using MvcAula20.Models;
using MvcAula20.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAula20.Controllers
{
    public class HomeController : Controller
    {
        private CarroRepository repository = new CarroRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listagem()
        {
            List<Carro> model = repository.Listar();

            return View(model);
        }
        public ActionResult Cadastro(int? id)
        {
            Carro model = new Carro();
           
            return View(model);
        }
        public ActionResult Salvar(Carro model)
        {
            repository.Salvar(model);
            return RedirectToAction("Cadastro");
        }
        public ActionResult Excluir(int id)
        {
            repository.Excluir(id);
            return RedirectToAction("Listagem");
        }

    }
}