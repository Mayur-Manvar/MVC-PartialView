using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPartialViewDemo.Startup))]
namespace MVCPartialViewDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
