using System.Threading.Tasks;
using AuthenticationServer.Models.TokenAuth;
using AuthenticationServer.Web.Controllers;
using Shouldly;
using Xunit;

namespace AuthenticationServer.Web.Tests.Controllers
{
    public class HomeController_Tests: AuthenticationServerWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}