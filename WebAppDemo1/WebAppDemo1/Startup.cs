using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppDemo1.Startup))]
namespace WebAppDemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
