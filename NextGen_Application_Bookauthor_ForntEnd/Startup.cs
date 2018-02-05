using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NextGen_Application_Bookauthor_ForntEnd.Startup))]
namespace NextGen_Application_Bookauthor_ForntEnd
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
