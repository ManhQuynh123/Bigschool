using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschool2004.Startup))]
namespace Bigschool2004
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
