using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApartmentManage.Startup))]
namespace ApartmentManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
