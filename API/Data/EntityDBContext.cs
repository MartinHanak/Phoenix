using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Entities 
{
    public class EntityDBContext: IdentityDbContext 
    {
        public EntityDBContext(DbContextOptions<EntityDBContext> options) : base(options) {

        }

        public DbSet<Test> Tests {get; set;}


    }
}