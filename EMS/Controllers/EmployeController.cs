using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return View();
        }

        public ActionResult Create(Employe model)
        {
            if (ModelState.IsValid)
            {
                db.Employes.Add(model);
                db.SaveChanges();
            }
            return View();

        }

    }
}