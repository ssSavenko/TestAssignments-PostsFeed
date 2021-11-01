

namespace TestAssigment.Models.DAL
{
    using Microsoft.EntityFrameworkCore;

    public class DatabseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabseContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions) { }

        public DbSet<DbPostData> PostsData { get; set; }
        public DbSet<DbComments> Comments { get; set; }
        public DbSet<DbPostItem> PostItem { get; set; }
    }
}
