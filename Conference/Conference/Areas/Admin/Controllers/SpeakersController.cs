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
    public class SpeakersController : Controller
    {
        private readonly ISpeakersService speakerService;

        public SpeakersController(ISpeakersService speakerService)
        {
            this.speakerService = speakerService;
        }
                
        // GET: Speakers
        public ActionResult Index()
        {
            IEnumerable<Speakers> allSpeakers = speakerService.GetAllSpeakers();
            return View(allSpeakers);
        }
        
        // GET: Speakers/Details/5
        public ActionResult Details(int id)
        {
            Speakers speakers = speakerService.GetSpeakerById(id);
            SpeakersViewModel model = new SpeakersViewModel();
            model.InjectFrom(speakers);
            return View(speakers);
        }
                
        // GET: Speakers/Create
        public ActionResult Create()
        {
            return View();
        }
                
        // POST: Speakers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SpeakersViewModel model)
        {
            if (ModelState.IsValid)
            {

                Speakers speaker = new Speakers();
                speaker.InjectFrom(model);

                var speakerToCreate = speakerService.AddSpeaker(speaker);

                if (speakerToCreate == null)
                {
                    ModelState.AddModelError("Name", "Speaker name must be unique!");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
                //return View(model);
            }

            //return RedirectToAction(nameof(Index));
            else
            {
                return View(model);
            }

        }
        
        // GET: Speakers/Edit/5
        public ActionResult Edit(int id)
        {
            var speaker = speakerService.GetSpeakerById(id);
            SpeakersViewModel model = new SpeakersViewModel();
            model.InjectFrom(speaker);
            return View(model);
        }
                
        // POST: Speakers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SpeakersViewModel model)
        {
            if (ModelState.IsValid)
            {
                Speakers speakers = new Speakers();
                speakers.InjectFrom(model);
                var speakerToUpdate = speakerService.UpdateSpeaker(speakers);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(model);
            }
        }
        
        // GET: Speakers/Delete/5
        public ActionResult Delete(int id, bool? saveChangesError = false)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. try again, and if problem persists, contact your system administrator.";
            }

            var speakerToDelete = speakerService.GetSpeakerById(id);
            SpeakersViewModel model = new SpeakersViewModel();

            if (speakerToDelete == null)
            {
                return NotFound();
            }
            else
            {
                model.InjectFrom(speakerToDelete);
                return View(model);
            }
        }
        
        // POST: Speakers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SpeakersViewModel model)
        {
            try
            {
                Speakers speakerToDelete = new Speakers();
                speakerToDelete = speakerService.GetSpeakerById(id);
                model.InjectFrom(speakerToDelete);
                speakerService.Delete(speakerToDelete);
                speakerService.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id, saveChangesError = true });
            }
            return RedirectToAction(nameof(Index));
        }
    }
}