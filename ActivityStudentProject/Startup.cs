using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ActivityStudentProject.Startup))]
namespace ActivityStudentProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
