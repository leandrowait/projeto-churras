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
    public class EventsController : Controller
    {
        private readonly IEventService eventAppService;

        public EventsController(IEventService eventService)
        {
            this.eventAppService = eventService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        // GET: Events
        [HttpGet]
        public ActionResult List()
        {
            var events = eventAppService.GetAll();
            var eventViewModel = Mapper.Map<IEnumerable<Event>, IEnumerable<EventViewModel>>(events);
            return View(eventViewModel);
        }

        // GET: Events/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var @event = eventAppService.GetBayId(id);
            var eventViewModel = Mapper.Map<Event, EventViewModel>(@event);
            return View(eventViewModel);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventViewModel @event)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var eventDomain = Mapper.Map<EventViewModel, Event>(@event);
                    eventAppService.Add(eventDomain);

                    return RedirectToAction("List");
                }
                catch
                {
                    return View(@event);
                }
            }

            return View(@event);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int id)
        {
            var @event = eventAppService.GetBayId(id);
            var eventViewModel = Mapper.Map<Event, EventViewModel>(@event);
            return View(eventViewModel);
        }

        // POST: Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EventViewModel @event)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var eventDomain = Mapper.Map<EventViewModel, Event>(@event);
                    eventAppService.Update(eventDomain);

                    return RedirectToAction("List");
                }
                catch
                {
                    return View(@event);
                }
            }

            return View(@event);
        }

        // GET: Events/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var @event = eventAppService.GetBayId(id);
            var eventViewModel = Mapper.Map<Event, EventViewModel>(@event);
            return View(eventViewModel);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var @event = eventAppService.GetBayId(id);
                eventAppService.Remove(@event);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    }
}
