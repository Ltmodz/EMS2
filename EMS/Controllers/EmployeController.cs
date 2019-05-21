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
            List<Employe> employes = db.Employes.Include("permenentUser").ToList();
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
                employe = db.Employes.Include("permenentUser").SingleOrDefault(e=>e.id == id),
                maritalStates = db.MaritalStates.ToList(),

            };

            PromotionVM promotionModel = new PromotionVM
            {
                jobDegrees = db.JobDegrees.ToList(),
                jobGroups = db.jobGroups.ToList(),
                permenentUser = model.employe.permenentUser
            };
            model.promotionVM = promotionModel;
            return View(model);
        }

        public ActionResult promote(int id)
        {
            PromotionVM model = new PromotionVM
            {
                jobDegrees = db.JobDegrees.ToList(),
                jobGroups = db.jobGroups.ToList()
            };
            return View(model);
        }







        public ActionResult promoteUser(PromotionVM model,int employeId)
        {

            
            //if the model is valid
            if(ModelState.IsValid)
            {
                //update the user to make him permenent
                Employe emp = db.Employes.Include("permenentUser").SingleOrDefault(e => e.id == employeId);
                emp.permenentUser = model.permenentUser;
                db.Employes.AddOrUpdate(emp);
                db.SaveChanges();
                return RedirectToAction("details", "Employe", new { id = employeId });
            }
            else
            {
                model.jobDegrees = db.JobDegrees.ToList();
                model.jobGroups = db.jobGroups.ToList();
                return View("promote",model);
            }

        }

    }
}