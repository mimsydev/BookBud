using Microsoft.AspNetCore.Mvc;

namespace BookBud.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : Controller
    {
        [HttpGet]
        public string Get() => "Healthy";
    }
}
