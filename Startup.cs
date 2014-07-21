using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HighChartDemo.Startup))]
namespace HighChartDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
