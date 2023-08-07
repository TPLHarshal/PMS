using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PMS.Data;
using PMS.Models;
using ProjectRecord4_API.Repository;

namespace PMS.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectRepository _pRepo;

        [BindProperty]
        public Project Project { get; set; }
        public ProjectsController( IProjectRepository pRepo)
        {
            _pRepo = pRepo;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(_pRepo.GetAll());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var user =  _pRepo.Find(id.GetValueOrDefault());
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _pRepo.Add(project);
                return RedirectToAction(nameof(Index));
            }
            return View(project);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            Project = _pRepo.Find(id.GetValueOrDefault()); ;
            if (Project == null)
            {
                return NotFound();
            }
            return View(Project);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {
            if (id != Project.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _pRepo.Update(Project);
                return RedirectToAction(nameof(Index));
            }
            return View(Project);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            _pRepo.Remove(id.GetValueOrDefault());
            return RedirectToAction(nameof  (Index));
        }

 

    }
}
