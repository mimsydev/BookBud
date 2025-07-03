using Microsoft.AspNetCore.Mvc;
using BookBud.Server.Models;
using BookBud.Server.Services;
using Microsoft.Extensions.Logging.Abstractions;

namespace BookBud.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController(IBookService bookService) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<BookDetail>>> GetBooks()
        {
            var books = await bookService.GetBooksAsync();
            if (books == null) 
            {
                return BadRequest();
            }
            return books;
        }

        [HttpGet("{bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BookDetail>> GetBook(Guid bookId)
        {
            if(bookId == Guid.Empty)
            {
                return BadRequest("BookId cannot be empty");
            }

            BookDetail bookDetail = await bookService.GetBookAsync(bookId);

            if (bookDetail == null)
            {
                return NotFound();
            }

            return bookDetail;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<BookDetail>> CreateBook([FromBody] BookDetail bookDetail)
        {
            var newBook = await bookService.CreateBookAsync(bookDetail);
            return newBook;
        }

        [HttpPut("{bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest | StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BookDetail>> UpdateBook ([FromBody] BookDetail bookDetail, Guid bookId)
        {
            var modifiedBook = await bookService.UpdateBookAsync(bookId, bookDetail);
            return modifiedBook;
        }

        [HttpDelete("{bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest | StatusCodes.Status404NotFound)]
        public async Task<ActionResult<bool>> DeleteBook(Guid bookId)
        {
            await bookService.DeleteBookAsync(bookId);
            return true;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest | StatusCodes.Status404NotFound)]
        [Route("api/[controller]/search")]
        public async Task<ActionResult<List<OpenLibBook>>> SearchBook()
        {
            List<OpenLibBook> books = [];
            return books;
        }
    }
}
