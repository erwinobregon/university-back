using Owin;
using University.BL.Data;

namespace University.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.CreatePerOwinContext(UniversityContext.Create);
        }
    }
}
