using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonContosoMVC5.Startup))]
namespace MonContosoMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
