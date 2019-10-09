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
    public class EditionsController : Controller
    {
        private readonly IEditionsService editionService;

        public EditionsController(IEditionsService editionService)
        {
            this.editionService = editionService;
        }

        [Area("Admin")]
        // GET: Editions
        public ActionResult Index()
        {
            IEnumerable<Editions> allEditions = editionService.GetAllEditions();
            return View(allEditions);
        }

        [Area("Admin")]
        // GET: Editions/Details/5
        public ActionResult Details(int id)
        {
            Editions editions = editionService.GetEditionById(id);
            EditionsViewModel model = new EditionsViewModel();
            model.InjectFrom(editions);
            return View(editions);
        }

        [Area("Admin")]
        // GET: Editions/Create
        public ActionResult Create()
        {
            return View();
        }

        [Area("Admin")]
        // POST: Editions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Editions model)
        {
            if (ModelState.IsValid)
            {
                Editions edition = new Editions();

                edition.InjectFrom(model);

                var editionToCreate = editionService.AddEdition(edition);

                if (editionToCreate == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }


        [Area("Admin")]
        // GET: Editions/Edit/5
        public ActionResult Edit(int id)
        {
            var edition = editionService.GetEditionById(id);
            EditionsViewModel model = new EditionsViewModel();
            model.InjectFrom(edition);
            return View(model);
        }

        [Area("Admin")]
        // POST: Editions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditionsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Editions edition = new Editions();
                edition.InjectFrom(model);
                var editionToUpdate = editionService.UpdateEdition(edition);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }

        [Area("Admin")]
        // GET: Editions/Delete/5
        public ActionResult Delete(int id, bool? saveChangesError = false)
        {


            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if problem persists, contact your system administrator.";
            }

            var editionToDelete = editionService.GetEditionById(id);
            EditionsViewModel model = new EditionsViewModel();
            

            if (editionToDelete == null)
            {
                return NotFound();
            }
            else
            {
                model.InjectFrom(editionToDelete);
                return View(model);
            }
        }

        [Area("Admin")]
        // POST: Editions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, EditionsViewModel model)
        {
            try
            {
                Editions editionToDelete = new Editions();
                editionToDelete = editionService.GetEditionById(id);
                model.InjectFrom(editionToDelete);
                editionService.Delete(editionToDelete);
                editionService.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id, saveChangesError = true });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}