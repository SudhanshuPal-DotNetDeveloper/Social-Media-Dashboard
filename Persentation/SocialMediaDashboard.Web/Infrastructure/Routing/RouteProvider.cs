using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace SocialMediaDashboard.Web.Infrastructure.Routing
{
    public partial class RouteProvider
    {
        public static void RegistorRoute(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(routes =>
            {
                #region Default Route

                routes.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                #endregion

                #region Other Routes



                #endregion
            });
        }
    }
}
