using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Glide.Startup))]
namespace Glide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
