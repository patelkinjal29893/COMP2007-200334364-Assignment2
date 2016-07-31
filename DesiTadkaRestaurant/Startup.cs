using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesiTadkaRestaurant.Startup))]
namespace DesiTadkaRestaurant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
