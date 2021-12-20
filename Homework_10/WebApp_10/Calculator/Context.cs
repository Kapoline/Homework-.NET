using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WebApp_10.Models;

namespace WebApp_10
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options) {}
        public DbSet<ExpressionModel> ExpressionCache { get; set; }
    }
}