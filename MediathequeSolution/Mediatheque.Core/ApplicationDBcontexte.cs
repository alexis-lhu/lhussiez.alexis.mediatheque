using Mediatheque.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mediatheque.Core
{
    public class ApplicationDBcontexte : DbContext
    {

        public DbSet<CD> CDs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Port=3306;Database=dbcontext;Uid=root;Pwd=;";
        var serverVersion = new MySqlServerVersion(new Version(8, 1, 12));
        optionsBuilder.UseMySql(connectionString, serverVersion)
            .LogTo(Console.WriteLine)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors();
    }
}
}
