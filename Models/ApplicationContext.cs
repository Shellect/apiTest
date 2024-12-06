using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ApiTest.Models
{
    public class ApplicationContext(DbContextOptions<ApplicationContext> options): IdentityDbContext<User>(options)
    {
        
    }
}