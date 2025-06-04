using Microsoft.AspNetCore.Mvc;
using BookBud.Server.Models;
using BookBud.Server.Services;
using Microsoft.Extensions.Logging.Abstractions;

namespace BookBud.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController(IBookService bookService) : ControllerBase
    {
        private IBookService bookService => bookService;

        [HttpGet("{bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Task<ActionResult<BookDetail>> GetBook(Guid bookId)
        {
            BookDetail bookDetail = bookService.GetBook(bookId);


        }
    }
}
