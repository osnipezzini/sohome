using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using SOHome.Auth.Data;
using SOHome.Auth.Models;

namespace SOHome.Auth.Configurations;

public static class AuthenticationConfigurationExtension
{
    public static void AddAuthenticationConfiguration(this IServiceCollection services)
    {
        services
            .AddDefaultIdentity<User>(SetIdentityOptions)
            .AddEntityFrameworkStores<ApplicationDbContext>();
        services.ConfigureApplicationCookie(SetCookieAuthenticationOptions);
    }
    private static void SetCookieAuthenticationOptions(CookieAuthenticationOptions options)
    {
        // Cookie settings
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

        options.LoginPath = "/Identity/Account/Login";
        options.AccessDeniedPath = "/Identity/Account/AccessDenied";
        options.SlidingExpiration = true;
    }

    private static void SetIdentityOptions(IdentityOptions options)
    {
        // SignIn settings.
        options.SignIn.RequireConfirmedAccount = true;
        
        // Password settings.
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequiredLength = 6;
        options.Password.RequiredUniqueChars = 0;
        
        // Lockout settings.
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.AllowedForNewUsers = true;

        // User settings.
        options.User.RequireUniqueEmail = true;
        options.User.AllowedUserNameCharacters =
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._";
    }
}