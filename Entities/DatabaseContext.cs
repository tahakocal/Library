using System.Data.Entity;

namespace LibraryAutomation.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"Data Source=93.177.102.219;Initial Catalog=LibraryDatabase;User ID=taha;Password=60s9KwSr$HG7m;")
        {

        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<RentBook> RentBooks { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Shelve> Shelves { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

    }
}
