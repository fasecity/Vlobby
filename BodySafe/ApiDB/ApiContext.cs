using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.LobbyCat;

namespace BodySafe
{


    public class ApiContext : DbContext
    {

        public static string CONNSTRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LobbyBoyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        public DbSet<ROW> LobbyActivity { get; set; }
      //  public DbSet<User> Users { get; set; }//---needs migration
      //  public DbSet<Staff> Staffs { get; set; }//--> staff subsystem Hackathon Model


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(CONNSTRING);


        }

    }
}


