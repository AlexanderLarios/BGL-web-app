using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Set_Works_PredictBGL.Startup))]
namespace Set_Works_PredictBGL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
