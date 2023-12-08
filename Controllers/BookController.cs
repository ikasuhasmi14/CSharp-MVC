using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCproject.Data;
using MVCproject.Models;

namespace MVCproject.Controllers;

public class BookController : Controller 
{
    private ApplicationDbContext _db;

    public BookController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var books = _db.Books.ToList();
        return View(books);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateBook(BooksEntity book){
        _db.Books.Add(book);
        _db.SaveChanges();

        return RedirectToAction("Index");

    }
}