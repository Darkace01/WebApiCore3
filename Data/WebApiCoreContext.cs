using Microsoft.EntityFrameworkCore;
using WebApiCore3.Models;

namespace WebApiCore3.Data
{
    public class WebApiCoreContext : DbContext
    {
        public WebApiCoreContext(DbContextOptions<WebApiCoreContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}