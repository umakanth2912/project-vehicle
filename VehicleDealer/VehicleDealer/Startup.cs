using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleDealer.Startup))]
namespace VehicleDealer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
