using BDServer.Models;
using Microsoft.EntityFrameworkCore;

namespace BDServer
{
    public class DbConnection : DbContext
    {
        public DbConnection(DbContextOptions<DbConnection> options) : base(options) {}
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}