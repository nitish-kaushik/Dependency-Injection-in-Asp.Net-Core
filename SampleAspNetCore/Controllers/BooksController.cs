using Microsoft.AspNetCore.Mvc;
using SampleAspNetCore.Models;
using SampleAspNetCore.Repositories;

namespace SampleAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBookRepository _bookRepository2;

        /// <summary>
        /// Constructor Injection
        /// </summary>
        /// <param name="bookRepository"></param>
        /// <param name="bookRepository2"></param>
        public BooksController(IBookRepository bookRepository, IBookRepository bookRepository2)
        {
            _bookRepository = bookRepository;
            _bookRepository2 = bookRepository2;
        }

[HttpPost("")]
public IActionResult AddBook([FromBody] BookModel book)
{
    _bookRepository.AddBook(book); // Add book using first instance
    var books = _bookRepository2.GetAllBooks(); // Get all books using secind instance
    return Ok(books);
}

        [HttpGet("")]
        public IActionResult GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks();
            return Ok(books);
        }
    }
}
