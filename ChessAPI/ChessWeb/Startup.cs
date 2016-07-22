using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChessWeb.Startup))]
namespace ChessWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
