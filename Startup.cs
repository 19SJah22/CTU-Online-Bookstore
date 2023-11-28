using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ctuOnlineBookstore.Startup))]
namespace ctuOnlineBookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
