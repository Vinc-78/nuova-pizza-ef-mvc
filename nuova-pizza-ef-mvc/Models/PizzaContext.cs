using nuova_pizza_ef_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace nuova_pizza_ef_mvc
{

    public class PizzaContext : DbContext
    {



        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options)
        {
        }

        public DbSet<Pizza> Courses { get; set; }
       
      
       
    }
}
