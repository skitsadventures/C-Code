using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FA1_1.Startup))]
namespace FA1_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
