using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200416891_ECommerce.Startup))]
namespace _200416891_ECommerce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
