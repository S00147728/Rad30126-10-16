using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00156762Week6.Startup))]
namespace S00156762Week6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
