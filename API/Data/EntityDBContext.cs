using Microsoft.EntityFrameworkCore;

namespace API.Entities 
{
    public class EntityDBContext: DbContext 
    {
        public EntityDBContext(DbContextOptions<EntityDBContext> options) : base(options) {

        }

        public DbSet<Test> Tests {get; set;}


    }
}