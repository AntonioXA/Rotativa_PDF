﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFconASPyMVC.Context;
using EFconASPyMVC.Models;
using Rotativa.AspNetCore;
using Rotativa.AspNetCore.Options;

namespace EFconASPyMVC.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly MyDbContext _context;

        public UsuariosController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult UsuarioHeaderPDF()
        {
            return View("UsuarioHeaderPDF");
        }
        public IActionResult UsuarioFooterPDF()
        {
            return View("UsuarioFooterPDF");
        }

        public async Task<IActionResult> UsuarioPDF()
        {
            string _headerUrl = Url.Action("UsuarioHeaderPDF", "Usuarios", null, "https");
            string _footerUrl = Url.Action("UsuarioFooterPDF", "Usuarios", null, "https");
            var myDbContext = _context.Usuarios.Include(u => u.Alumno);
            return new ViewAsPdf("UsuarioPDF", await _context.Usuarios.ToListAsync())
            {
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageSize = Rotativa.AspNetCore.Options.Size.A4,

                PageMargins = new Margins { Bottom = 30, Left = 10, Right = 10, Top = 100 },
                CustomSwitches = "--header-html " + _headerUrl + " --header-spacing 10 --footer-html " + _footerUrl + " --footer-spacing 10"
            }; ;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.Usuarios.Include(u => u.Alumno);
            return View(await myDbContext.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.Alumno)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Id");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreUsuario,AlumnoId")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Id", usuario.AlumnoId);
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Id", usuario.AlumnoId);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreUsuario,AlumnoId")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlumnoId"] = new SelectList(_context.Alumnos, "Id", "Id", usuario.AlumnoId);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.Alumno)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
