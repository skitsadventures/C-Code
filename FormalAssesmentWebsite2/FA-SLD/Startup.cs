using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FA_SLD.Startup))]
namespace FA_SLD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
