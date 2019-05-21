using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EMS.ViewModels.TrainingsVM;
using EMS.Models;
using System.Data.Entity.Migrations;

namespace EMS.Controllers
{
    public class TrainingsController : Controller
    {
        ApplicationDbContext db;
        public TrainingsController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Trainigs
        public ActionResult Index(IndexVM _model)
        {


            if(_model.employeId == 0)
            {
                IndexVM model = new IndexVM
                {
                    employes = db.Employes.ToList()
                };
                return View(model);
            }

            else
            {
                IndexVM model = new IndexVM
                {
                    employes = db.Employes.ToList(),
                    trainings = db.trainings.Include("result")
                                            .Include("grade")
                                            .Where(t => t.employeId == _model.employeId).ToList(),
                    employeId = _model.employeId
                };
                return View(model);
            }


        }

        public ActionResult New(int? id)
        {
            //adding the trainings for the user
            List<Employe> employes = new List<Employe>();
            if(id != null)
            {
                employes = db.Employes.Where(e => e.id == id).ToList();
            }
            else
            {
                employes = db.Employes.ToList();
            }
            AddVM model = new AddVM
            {
                employes = employes,
                grades = db.grades.ToList(),
                results = db.results.ToList()
            };

            return View(model);
        }

        public ActionResult Create(AddVM model)
        {
            if(ModelState.IsValid)
            {
                db.trainings.Add(model.training);
                db.SaveChanges();
                IndexVM _model = new IndexVM
                {
                    employes = db.Employes.ToList(),
                    trainings = db.trainings.Include("result")
                                            .Include("grade")
                                            .Where(t => t.employeId == model.training.employeId).ToList(),
                    employeId = model.training.employeId
                };
                return View("index",_model);
            }

            else
            {
                model.results = db.results.ToList();
                model.grades = db.grades.ToList();
                return View("New", model);
            }
        }


        public ActionResult details(int id)
        {
            DetailsVM model = new DetailsVM
            {
                training = db.trainings.Include("result").Include("grade").SingleOrDefault(e => e.id == id),
                grades = db.grades.ToList(),
                results = db.results.ToList()
            };
            return View(model);
        }

        public ActionResult update(DetailsVM model)
        {
            if(ModelState.IsValid)
            {
                db.trainings.AddOrUpdate(model.training);
                db.SaveChanges();
                model.results = db.results.ToList();
                model.grades  = db.grades.ToList();
                return View("details", model);
            }
            else
            {
                model.results = db.results.ToList();
                model.grades = db.grades.ToList();
                return View("details", model);
            }
        }

        public ActionResult delete(int id)
        {
            Training training = db.trainings.SingleOrDefault(t => t.id == id);
            db.trainings.Remove(training);
            db.SaveChanges();

            IndexVM _model = new IndexVM
            {
                employes = db.Employes.ToList(),
                trainings = db.trainings.Include("result")
                             .Include("grade")
                             .Where(t => t.employeId == training.employeId).ToList(),
                employeId = training.employeId
            };
            return RedirectToAction("index", _model);
        }

    }
}