﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vets.Data;
using Vets.Models;

namespace Vets.Controllers
{
    public class DonosController : Controller
    {
        private readonly VetsDB db;

        public DonosController(VetsDB context)
        {
            db = context;
        }

        // GET: Donos
        /// <summary>
        /// Invoca a View Index
        /// </summary>
        /// <param name="id"> identificador do Dono a detalhar </param>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            // em SQL, db.Donos.ToListAsync() significa:
            // Select * FROM Donos 
            return View(await db.Donos.ToListAsync());
        }

        // GET: Donos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                //não foi fornecido o ID pq o utilizador o eliminou propositadamente
                //por isso, redireciono o utilizador para a página de Index
                return RedirectToAction("Index");
            }

            // Em SQL, db.Donos.FirstOrDefaultAsync(m => m.ID == id) significa
            // Select * FROM Donos d WHERE d.ID = id
            var dono = await db.Donos.FirstOrDefaultAsync(d => d.ID == id);

            /// d => d.Id == id -> expressão lógica
            /// ^
            /// |
            /// 'variável' que identifica cada um dos registos da tabela Donos
            /// esta 'variável' chama-se 'd' pq dessa forma associa-se mais facilmente aos Donos
            ///             
            ///     ^           
            ///     |
            ///     => - simples separador
            ///         ^
            ///         | 
            ///         d - identifica o registo que está a ser processado
            ///         d.ID - identifica o atributo 'ID' desse registo
            ///         d.ID == id -> expressão lógica, devolvendo 'true' ou 'false'
            ///     

            if (dono == null)
            {
                //não foi fornecido o ID pq o utilizador o eliminou propositadamente
                //por isso, redireciono o utilizador para a página de Index
                return RedirectToAction("Index");
            }

            return View(dono);
        }

        // GET: Donos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Donos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,NIF")] Donos dono)
        {

            if (ModelState.IsValid)
            {
                db.Add(dono);
                await db.SaveChangesAsync(); // commit
                return RedirectToAction(nameof(Index));
            }
            // alguma coisa correu mal.
            // devolve-se o controlo da aplicação à View
            return View(dono);
        }

        // GET: Donos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                //não foi fornecido o ID pq o utilizador o eliminou propositadamente
                //por isso, redireciono o utilizador para a página de Index
                return RedirectToAction("Index");
            }

            var donos = await db.Donos.FindAsync(id);
            if (donos == null)
            {
                return NotFound();
            }
            return View(donos);
        }

        // POST: Donos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,NIF")] Donos dono)
        {
            if (id != dono.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(dono);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonosExists(dono.ID))
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
            return View(dono);
        }

        // GET: Donos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donos = await db.Donos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (donos == null)
            {
                return NotFound();
            }

            return View(donos);
        }

        // POST: Donos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donos = await db.Donos.FindAsync(id);
            db.Donos.Remove(donos);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonosExists(int id)
        {
            return db.Donos.Any(e => e.ID == id);
        }
    }
}
