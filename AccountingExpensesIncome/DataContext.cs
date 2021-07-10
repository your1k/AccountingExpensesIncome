using System.Data.Entity;

namespace AccountingExpensesIncome
{
   public class DataContext : DbContext
   {
        // контекст EF6 для работы с базой данных. При необходимости строку подключения можно заменить.
        public DataContext() : base("DataContextConnectionString"){ }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Operations> Operations { get; set; }
        public DbSet<Recipients> Recipients { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Data> Data { get; set; }
    }
}
