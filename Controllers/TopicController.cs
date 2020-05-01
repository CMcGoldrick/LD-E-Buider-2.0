using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.ViewProviders.Interfaces;
using Lethal.Developer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Lethal.Developer.Controllers
{
    //[Authorize]
    public class TopicController : Controller
    {
        private readonly ITopicProvider _topicProvider;

        public TopicController(ITopicProvider topicProvider)
        {
            _topicProvider = topicProvider;
        }

        // GET: Topic
        public ActionResult<Topic> Index()
        {
            try
            {
                var userId = Guid.Parse("9776506B-8CFE-448F-1BF5-08D7DCE61A3B");

                var topic = _topicProvider.GetAllTopicsAsync(userId);
                return PartialView("_TopicsPartial", topic);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // GET: Topic/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Topic/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Topic/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Topic/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Topic/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Topic/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}