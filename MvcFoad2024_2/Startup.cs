using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;

using MvcFoad2024_2.App_Start;
using MvcFoad2024_2.Models;

using Owin;

using System;

[assembly: OwinStartupAttribute(typeof(MvcFoad2024_2.Startup))]
namespace MvcFoad2024_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRoleandUsers();
        }

        private void createRoleandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            UtilsSecurity us=new UtilsSecurity();
            var roleManager= new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager= new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                    role.Name = "Admin";
                roleManager.Create(role);
                us.AddProfil(role.Name, role.Name);
                var user = new ApplicationUser();
                user.UserName = "Nafissa";
                user.Email = "nfarah@groupeisi.com";
                string userPWD = "Passer@123";
                var chkUser = userManager.Create(user, userPWD);
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");
                }
            }
            if (!roleManager.RoleExists("Auteur"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Auteur";
                roleManager.Create(role);
                us.AddProfil(role.Name, role.Name);
            }
            if (!roleManager.RoleExists("Expert")) 
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Expert";
                roleManager.Create(role);
                us.AddProfil(role.Name, role.Name);
            }
            if (!roleManager.RoleExists("Lecteur"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Lecteur";
                roleManager.Create(role);
                us.AddProfil(role.Name, role.Name);
            }
        }
    }
}
