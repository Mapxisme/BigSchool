using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lap4_LeDucThuan.Startup))]
namespace Lap4_LeDucThuan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
