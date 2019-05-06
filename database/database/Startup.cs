using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(database.Startup))]
namespace database
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
