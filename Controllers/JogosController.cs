using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Games_Mvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Mvc.Controllers
{
    public class JogosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JogosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jogos
        public async Task<IActionResult> Index()
        {
            var jogos = await _context.Jogos
                .Include(j => j.Personagens)
                .ToListAsync();
            return View(jogos);
        }

        // GET: Jogos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jogos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Jogo jogo, List<Personagem> personagens)
        {
            if (ModelState.IsValid)
            {
                _context.Jogos.Add(jogo);
                await _context.SaveChangesAsync();

                if (personagens != null)
                {
                    foreach (var personagem in personagens)
                    {
                        personagem.JogoId = jogo.Id;
                        _context.Personagens.Add(personagem);
                    }
                    await _context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(jogo);
        }

        // GET: Jogos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var jogo = await _context.Jogos
                .Include(j => j.Personagens)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        // POST: Jogos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Plataforma,Genero,ImagemUrl,Descricao")] Jogo jogo, List<Personagem> personagens)
        {
            if (id != jogo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogo);
                    await _context.SaveChangesAsync();

                    var existingPersonagens = _context.Personagens
                        .Where(p => p.JogoId == jogo.Id)
                        .ToList();

                    _context.Personagens.RemoveRange(existingPersonagens);

                    if (personagens != null)
                    {
                        foreach (var personagem in personagens)
                        {
                            personagem.JogoId = jogo.Id;
                            _context.Personagens.Add(personagem);
                        }
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JogoExists(jogo.Id))
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
            return View(jogo);
        }

        // GET: Jogos/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var jogo = await _context.Jogos
                .Include(j => j.Personagens)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }

        private bool JogoExists(int id)
        {
            return _context.Jogos.Any(e => e.Id == id);
        }
    }
}
