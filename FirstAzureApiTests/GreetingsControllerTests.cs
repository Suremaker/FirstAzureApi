using FirstAzureApi.Controllers;
using Shouldly;
using Xunit;

namespace FirstAzureApiTests
{
    public class GreetingsControllerTests
    {
        private readonly GreetingsController _controller = new GreetingsController();

        [Fact]
        public void Greetings_should_greet_me_politely()
        {
            _controller.Greetings().ShouldBe("Hello stranger!");
        }
    }
}
