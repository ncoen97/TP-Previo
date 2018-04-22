using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TP_Previo_2.Startup))]
namespace TP_Previo_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
