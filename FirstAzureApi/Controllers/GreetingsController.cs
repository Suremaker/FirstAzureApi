using Microsoft.AspNetCore.Mvc;

namespace FirstAzureApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        public string Greetings() => "Hello stranger!";

        [HttpGet("{name}")]
        public string Greetings(string name) => $"Hello {name}!";
    }
}
