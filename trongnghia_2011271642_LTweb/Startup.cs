using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(trongnghia_2011271642_LTweb.Startup))]
namespace trongnghia_2011271642_LTweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
