using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GluWebsite.Startup))]
namespace GluWebsite
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
