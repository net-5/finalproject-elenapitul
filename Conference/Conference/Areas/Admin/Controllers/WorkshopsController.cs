using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkshopsController : Controller
    {
        private readonly IWorkshopsService workshopService;

        public WorkshopsController(IWorkshopsService workshopService)
        {
            this.workshopService = workshopService;
        }
                
        // GET: Workshops
        public ActionResult Index()
        {
            IEnumerable<Workshops> allWorkshops = workshopService.GetAllWorkshops();
            return View(allWorkshops);
        }
               
        // GET: Workshops/Details/5
        public ActionResult Details(int id)
        {
            Workshops workshops = workshopService.GetWorkshopById(id);
            WorkshopsViewModel model = new WorkshopsViewModel();
            model.InjectFrom(workshops);
            return View(workshops);
        }
               
        // GET: Workshops/Create
        public ActionResult Create()
        {
            return View();
        }
                
        // POST: Workshops/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkshopsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Workshops workshop = new Workshops();
                workshop.InjectFrom(model);
                var createNewWorkshop = workshopService.AddWorkshop(workshop);
                if (createNewWorkshop == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }

            return View(model);

            
        }
        
        // GET: Workshops/Edit/5
        public ActionResult Edit(int id)
        {
            var workshop = workshopService.GetWorkshopById(id);
            WorkshopsViewModel model = new WorkshopsViewModel();
            model.InjectFrom(workshop);
            return View(model);
        }
                       
        // POST: Workshops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WorkshopsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Workshops workshop = new Workshops();
                workshop.InjectFrom(model);
                var workshopToUpdate = workshopService.UpdateWorkshop(workshop);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }
                
        // GET: Workshops/Delete/5
        public ActionResult Delete(int id, bool? saveChangesError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if problem persists, contact your system administrator.";
            }

            var workshopToDelete = workshopService.GetWorkshopById(id);
            WorkshopsViewModel model = new WorkshopsViewModel();

            if (workshopToDelete == null)
            {
                return NotFound();
            }
            else
            {
                model.InjectFrom(workshopToDelete);
                return View(model);
            }
        }
       
        // POST: Workshops/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, WorkshopsViewModel model)
        {
            try
            {
                Workshops workshopToDelete = new Workshops();
                workshopToDelete = workshopService.GetWorkshopById(id);
                model.InjectFrom(workshopToDelete);
                workshopService.Delete(workshopToDelete);
                workshopService.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id, saveChangesError = true });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}