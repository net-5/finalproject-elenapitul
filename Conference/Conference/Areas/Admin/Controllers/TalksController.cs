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
    public class TalksController : Controller
    {
        private readonly ITalksService talkService;

        public TalksController(ITalksService talkService)
        {
            this.talkService = talkService;
        }
        
        // GET: Talks
        public ActionResult Index()
        {
            IEnumerable<Talks> allTalks = talkService.GetAllTalks();
            return View(allTalks);
        }
                
        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            Talks talk = talkService.GetTalkById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(talk);
            return View(talk);
        }
                
        // GET: Talks/Create
        public ActionResult Create()
        {
            return View();
        }
                
        // POST: Talks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TalksViewModel model)
        {
            if (ModelState.IsValid)
            {
                Talks talk = new Talks();
                talk.InjectFrom(model);
                var createNewTalk = talkService.AddTalk(talk);

                if (createNewTalk == null)
                {
                    ModelState.AddModelError("Name", "The Name must be unique!");

                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);

        }
        
        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
            var talk = talkService.GetTalkById(id);
            TalksViewModel model = new TalksViewModel();
            model.InjectFrom(talk);
            return View(model);
        }
                
        // POST: Talks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Talks model)
        {
            if (ModelState.IsValid)
            {
                Talks talk = new Talks();
                talk.InjectFrom(model);
                var talkToUpdate = talkService.UpdateTalk(talk);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }
                
        // GET: Talks/Delete/5
        public ActionResult Delete(int id, bool? saveChangesError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. try again, and if problem persists, contact your system administrator.";
            }

            var talkToDelete = talkService.GetTalkById(id);
            TalksViewModel model = new TalksViewModel();

            if (talkToDelete == null)
            {
                return NotFound();

            }
            else
            {
                model.InjectFrom(talkToDelete);
                return View(model);
            }
        }
                
        // POST: Talks/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TalksViewModel model)
        {
            try
            {
                Talks talkToDelete = new Talks();
                talkToDelete = talkService.GetTalkById(id);
                model.InjectFrom(talkToDelete);
                talkService.Delete(talkToDelete);
                talkService.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id, saveChangesError = true });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}