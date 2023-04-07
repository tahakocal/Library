using System.Data.Entity;

namespace Library.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base(@"Data Source=93.177.102.219;Initial Catalog=LibraryDatabase;User ID=taha;Password=60s9KwSr$HG7m;")
        {

        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<RentBook> RentBooks { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSubscription> UserSubscriptions { get; set; }

    }
}
