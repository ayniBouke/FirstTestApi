using Microsoft.Owin;

[assembly: OwinStartup(typeof(ApiTest.Startup))]
namespace ApiTest
{
    public partial class Startup
    {
        // public void Configuration(IAppBuilder app)
        //  {
        //ConfigureAuth(app);
        // }
    }
}