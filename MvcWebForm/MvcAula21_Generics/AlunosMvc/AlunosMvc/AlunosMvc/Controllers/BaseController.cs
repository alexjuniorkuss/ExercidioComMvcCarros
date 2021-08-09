using AlunosMvc.Models;
using AlunosMvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlunosMvc.Controllers
{
    public abstract class BaseController<M, R> : Controller where M:BaseModel where R: BaseRepository<M>
    {

        R repository;
        public BaseController(R repository)
        {
            this.repository = repository;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(M model)
        {
            repository.Create(model);
            ModelState.Clear();
            return View();
        }

        public ActionResult Read()
        {
            return View(repository.Read());
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            M model = repository.Read(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Update(M model)
        {
            repository.Update(model);
            return RedirectToAction("Read");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(repository.Read(id));
        }
        [HttpPost]
        public ActionResult Delete(M model)
        {
            repository.Delete(repository.Read(model.Id));
            return RedirectToAction("Read");
        }
        public ActionResult Details(int id)
        {
            M model = repository.Read(id);
            return View(model);
        }

    }
}