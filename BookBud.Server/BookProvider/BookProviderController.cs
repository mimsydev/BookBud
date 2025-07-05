using Microsoft.AspNetCore.Mvc;

namespace BookBud.Server.BookProvider
{
    public class BookProviderController : Controller
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest | StatusCodes.Status404NotFound)]
        [Route("api/[controller]/search")]
        public async Task<ActionResult<List<IProvidedBook>>> GetBooks()
        {
            List<IProvidedBook> books = [];
            return books;
        }
    }
}
