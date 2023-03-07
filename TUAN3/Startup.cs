using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TUAN3.Startup))]
namespace TUAN3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
