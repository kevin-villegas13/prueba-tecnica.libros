using Biblioteca.Data;
using Biblioteca.DTO.Book;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Controllers;

public class BooksController(AppDbContext context) : Controller
{
    private readonly AppDbContext _context = context;

    public IActionResult Index()
    {
        var books = _context.Books.Include(b => b.Author).ToList();
        return View(books);
    }

    public IActionResult Create()
    {
        ViewBag.Authors = new SelectList(_context.Authors, "AuthorId", "Name");
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CreateBookDto bookDto)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Authors = new SelectList(_context.Authors, "AuthorId", "Name");
            return View(bookDto);
        }

        var book = new Book
        {
            Title = bookDto.Title,
            AuthorId = bookDto.AuthorId
        };

        _context.Books.Add(book);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var book = _context.Books.Find(id);
        if (book == null) return NotFound();

        var bookDto = new UpdateBookDto
        {
            Title = book.Title,
            AuthorId = book.AuthorId
        };

        ViewBag.Authors = new SelectList(_context.Authors, "AuthorId", "Name");
        return View(bookDto);
    }

    [HttpPost]
    public IActionResult Edit(int id, UpdateBookDto bookDto)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Authors = new SelectList(_context.Authors, "AuthorId", "Name");
            return View(bookDto);
        }

        var book = _context.Books.Find(id);
        if (book == null) return NotFound();

        book.Title = bookDto.Title;
        book.AuthorId = bookDto.AuthorId;

        _context.Update(book);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        var book = _context.Books.Find(id);
        if (book != null)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
