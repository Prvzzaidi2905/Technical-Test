using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Technical_Test.Startup))]
namespace Technical_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
