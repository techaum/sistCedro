using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sistCedro.Startup))]
namespace sistCedro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
