using HaverDevProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HaverDevProject.Data
{
    public static class ApplicationDbInitializer
    {
        public static async void Seed(IApplicationBuilder applicationBuilder)
        {
            ApplicationDbContext context = applicationBuilder.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<ApplicationDbContext>();
            try
            {
                //Create the database if it does not exist and apply the Migration
                context.Database.Migrate();

                //Create Roles
                var RoleManager = applicationBuilder.ApplicationServices.CreateScope()
                    .ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                string[] roleNames = { "Admin", "Quality", "Engineer", "Operations", "Procurement" };
                IdentityResult roleResult;
                foreach (var roleName in roleNames)
                {
                    var roleExist = await RoleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                    {
                        roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }
                //Create Users
                var userManager = applicationBuilder.ApplicationServices.CreateScope()
                    .ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                if (userManager.FindByEmailAsync("admin@example.com").Result == null)
                {
                    ApplicationUser user = new ApplicationUser
                    {
                        FirstName = "Admin",
                        LastName = "Role",
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Admin").Wait();
                    }
                }
                if (userManager.FindByEmailAsync("quality@example.com").Result == null)
                {
                    ApplicationUser user = new ApplicationUser
                    {
                        FirstName = "Quality",
                        LastName = "Role",
                        UserName = "quality@example.com",
                        Email = "quality@example.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Quality").Wait();
                    }
                }
                if (userManager.FindByEmailAsync("engineer@example.com").Result == null)
                {
                    ApplicationUser user = new ApplicationUser
                    {
                        FirstName = "Engineer",
                        LastName = "Role",
                        UserName = "engineer@example.com",
                        Email = "engineer@example.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Engineer").Wait();
                    }
                }
                if (userManager.FindByEmailAsync("operations@example.com").Result == null)
                {
                    ApplicationUser user = new ApplicationUser
                    {
                        FirstName = "Operations",
                        LastName = "Role",
                        UserName = "operations@example.com",
                        Email = "operations@example.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Operations").Wait();
                    }
                }
                if (userManager.FindByEmailAsync("procurement@example.com").Result == null)
                {
                    ApplicationUser user = new ApplicationUser
                    {
                        FirstName = "Procurement",
                        LastName = "Role",
                        UserName = "procurement@example.com",
                        Email = "procurement@example.com",
                        EmailConfirmed = true
                    };

                    IdentityResult result = userManager.CreateAsync(user, "Pa55w@rd").Result;

                    if (result.Succeeded)
                    {
                        userManager.AddToRoleAsync(user, "Procurement").Wait();
                    }
                }                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.GetBaseException().Message);
            }
        }
    }
}
