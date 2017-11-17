using AutoMapper;
using Churras.Domain.Contracts.Services;
using Churras.Domain.Events;
using Churras.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Churras.MVC.Controllers
{
    public class ParticipantsController : Controller
    {
        private readonly IParticipantService participantAppService;
        private readonly IEventService eventAppService;

        public ParticipantsController(IParticipantService participantAppService, IEventService eventAppService)
        {
            this.participantAppService = participantAppService;
            this.eventAppService = eventAppService;
        }

        // GET: Events/Participants/5
        [HttpGet]
        public ActionResult List(int id)
        {
            var @event = eventAppService.GetBayId(id);
            var participantsViewModel = Mapper.Map<IEnumerable<Participant>, IEnumerable<ParticipantViewModel>>(@event?.Participants);

            ViewBag.EventId = id;

            return View(participantsViewModel);
        }

        // GET: Participants/Details/5
        public ActionResult Details(int id)
        {
            var participant = participantAppService.GetBayId(id);
            var participantViewModel = Mapper.Map<Participant, ParticipantViewModel>(participant);
            return View(participantViewModel);
        }

        // GET: Participants/Create
        [HttpGet]
        public ActionResult Create(int id)
        {
            var @event = eventAppService.GetBayId(id);

            ViewBag.EventId = @event.EventId;
            ViewBag.ValueWithDrinkSugestion = @event.ValueWithDrink;
            ViewBag.ValueWithoutDrinkSugestion = @event.ValueWithoutDrink;

            return View();
        }

        // POST: Participants/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParticipantViewModel participant)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var participantDomain = Mapper.Map<ParticipantViewModel, Participant>(participant);
                    participantAppService.Add(participantDomain);
                    
                    return RedirectToAction("List", new { id = participant.EventId });
                }
                catch
                {
                    return View(participant);
                }
            }

            return View(participant);
        }

        // GET: Participants/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var participant = participantAppService.GetBayId(id);
            var participantViewModel = Mapper.Map<Participant, ParticipantViewModel>(participant);
            return View(participantViewModel);
        }

        // POST: Participants/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ParticipantViewModel participant)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var participantDomain = Mapper.Map<ParticipantViewModel, Participant>(participant);
                    participantAppService.Update(participantDomain);

                    return RedirectToAction("List", new { id = participantDomain.EventId });
                }
                catch
                {
                    return View(participant);
                }
            }

            return View(participant);
        }

        // GET: Participants/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var participant = participantAppService.GetBayId(id);
            var participantViewModel = Mapper.Map<Participant, ParticipantViewModel>(participant);
            return View(participantViewModel);
        }

        // POST: Participants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var participant = participantAppService.GetBayId(id);
                int eventId = participant.EventId;
                participantAppService.Remove(participant);

                return RedirectToAction("List", new { id = eventId });
            }
            catch
            {
                return View();
            }
        }
    }
}
