using Microsoft.Owin;
using Owin;
using EMS.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(EMS.Startup))]
namespace EMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRoles();
        }

        private void CreateRoles()
        {
            ///
            /// this function is used to create roles
            /// at the startup of the system
            /// add any value to the array to create a new role
            ///
            ApplicationDbContext db = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            string[] roles = new string[] { "Admin", "ComputerCenter", "Commander", "Gate"};

            foreach(var roleName in roles)
            {
                if(!roleManager.RoleExists(roleName))
                {
                    var role = new IdentityRole();
                    role.Name = roleName;
                    roleManager.Create(role);
                }
            }
        }
    }
}
