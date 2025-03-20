using Biblioteca.Data;
using Biblioteca.DTO.Author;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Controllers;

public class AuthorsController(AppDbContext appDbContext) : Controller
{
    private readonly AppDbContext _appDbContext = appDbContext;

    // Muestra la lista de autores
    public async Task<IActionResult> Index()
    {
        var authors = await _appDbContext.Authors.Include(a => a.Books).ToListAsync();
        return View(authors);
    }

    // Crear un nuevo autor (GET)
    public IActionResult Create()
    {
        return View();
    }

    // Guardar un nuevo autor (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateAuthorDto authorDto)
    {
        if (ModelState.IsValid)
        {
            var author = new Author { Name = authorDto.Name };
            _appDbContext.Authors.Add(author);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(authorDto);
    }

    // Editar un autor (GET)
    public async Task<IActionResult> Edit(int id)
    {
        var author = await _appDbContext.Authors.FindAsync(id);
        if (author == null) return NotFound();

        var authorDto = new UpdateAuthorDto { Name = author.Name };
        return View(authorDto);
    }

    // Guardar la edición del autor (POST)
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, UpdateAuthorDto authorDto)
    {
        var author = await _appDbContext.Authors.FindAsync(id);
        if (author == null) return NotFound();

        if (ModelState.IsValid)
        {
            author.Name = authorDto.Name;
            try
            {
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Error al actualizar el autor.");
            }
        }
        return View(authorDto);
    }

    // Ver detalles de un autor
    public async Task<IActionResult> Details(int id)
    {
        var author = await _appDbContext.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.AuthorId == id);
        if (author == null) return NotFound();

        return View(author);
    }

    // Vista de confirmación para eliminar
    public async Task<IActionResult> Delete(int id)
    {
        var author = await _appDbContext.Authors.FindAsync(id);
        if (author == null) return NotFound();

        return View(author);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var author = await _appDbContext.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.AuthorId == id);
        if (author == null) return NotFound();

        if (author.Books.Any())
        {
            return BadRequest("No se puede eliminar un autor con libros asociados.");
        }

        _appDbContext.Authors.Remove(author);
        await _appDbContext.SaveChangesAsync();

        return RedirectToAction("Index");
    }

}
