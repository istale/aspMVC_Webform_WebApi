using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_WebForm_WebApi.Startup))]
namespace MVC_WebForm_WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
