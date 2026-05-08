using Microsoft.AspNetCore.Mvc;
using MVC_project_New.Models;
using MVC_project_New.Services;

namespace MVC_project_New.Controllers
{
    public class BooksController : Controller
    {
        private BooksService _booksService;

        public BooksController(BooksService booksService) {
            _booksService = booksService;

        }

        [HttpGet]
        public async Task<IActionResult> Addmore()
        {
            var Items=await _booksService.Get();
            return View(Items);
        }

        [HttpPost]
        public async Task<IActionResult> Posters(Book newBook)
        {
            var BookDetails = new Book
            {
               
                BookName = newBook.BookName,
                Price = newBook.Price,
                Category = newBook.Category,
                Author = newBook.Author
            };
            await _booksService.Create(BookDetails);
            ViewBag.TotalBooks = "Created successfully";

            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Getter(Book bookid)
        {  
            String id = bookid.Id;
            
            var book = await _booksService.GetById(id);

            if (book is null)
            {
                return NotFound();
            }
            ViewBag.book = book;
            return View(book); 
        }


        [HttpPut]
        public async Task<IActionResult> Update(string id, Book updatedBook)
        {
            var book = await _booksService.GetById(id);

            if (book is null)
            {
                return NotFound();
            }

            updatedBook.Id = book.Id;

            await _booksService.Update(id, updatedBook);
            ViewBag.updates = "Updated successfully";
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Sorting(String bookdetail)
        {
           var sortedbook = await _booksService.Sorting(bookdetail);

            if (sortedbook is null)
            {
                return NotFound();
            }
            ViewBag.book = sortedbook;
            return View(sortedbook);
        }
    }   
}
