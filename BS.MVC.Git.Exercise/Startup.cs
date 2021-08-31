using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BS.MVC.Git.Exercise.Startup))]
namespace BS.MVC.Git.Exercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
