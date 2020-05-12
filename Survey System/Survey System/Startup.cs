using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Survey_System.Startup))]
namespace Survey_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
