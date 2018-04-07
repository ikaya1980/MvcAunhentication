using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAunhentication.Startup))]
namespace MvcAunhentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
