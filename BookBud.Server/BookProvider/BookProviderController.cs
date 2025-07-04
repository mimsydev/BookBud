using Microsoft.AspNetCore.Mvc;
using BookBud.Server.Models;

namespace BookBud.Server.Controllers
{
    public class BookProviderController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest | StatusCodes.Status404NotFound)]
        [Route("api/[controller]/search")]
        public async Task<ActionResult<List<BookDetail>>> GetBooks()
        {
            List<BookDetail> books = [];
            return books;
        }
    }
}
