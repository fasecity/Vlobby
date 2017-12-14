using CommsModel;
using Microsoft.EntityFrameworkCore;


namespace BodySafe
{


    public class ApiContext : DbContext
    {

        public static string CONNSTRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LobbyBoyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        //public DbSet<ROW> LobbyActivity { get; set; }//--old schema
        public DbSet<COMMSLOBBROW> CommsLobbActivity { get; set; }// comms model
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(CONNSTRING);


        }

    }
}


