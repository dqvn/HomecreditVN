using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomecreditVN.Startup))]
namespace HomecreditVN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
