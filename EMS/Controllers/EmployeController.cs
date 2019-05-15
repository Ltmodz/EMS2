using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.ViewModels.EmployeVM;
using EMS.Models;

namespace EMS.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        private ApplicationDbContext db;
        public EmployeController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            List<Employe> employes = db.Employes.ToList();
            return View(employes);
        }

        public ActionResult New()
        {
            CreateVM model = new CreateVM
            {
                maritalStates = db.MaritalStates.ToList()
            };
            return View(model);
        }

        public ActionResult Create(CreateVM model)
        {
            if (ModelState.IsValid)
            {
                db.Employes.Add(model.employe);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult update(EditVM model)
        {
            if(ModelState.IsValid)
            {
                db.Employes.AddOrUpdate(model.employe);
                db.SaveChanges();
                return RedirectToAction("details","Employe", new { id = model.employe.id });
            }
            else
            {
                model.maritalStates = db.MaritalStates.ToList();
                return View("details", model);
            }
        }

        public ActionResult details(int id)
        {
            EditVM model = new EditVM
            {
                employe = db.Employes.SingleOrDefault(e=>e.id == id),
                maritalStates = db.MaritalStates.ToList()
            };
            return View(model);
        }

    }
}