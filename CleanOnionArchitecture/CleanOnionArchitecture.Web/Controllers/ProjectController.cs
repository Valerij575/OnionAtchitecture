﻿using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanOnionArchitecture.Web.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        // GET:ProjectController
        public ActionResult Index()
        {
            return View(_projectService.GetProjects());
        }

        //GET: ProjectControlle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //GET:ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST:ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collecton)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET:ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //POST:ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET:ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        } 

        //POST:ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
