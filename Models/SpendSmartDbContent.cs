using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    public class SpendSmartDbContent : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
       
       public SpendSmartDbContent(DbContextOptions<SpendSmartDbContent> options)
       : base(options)
       {
        
       }
    }
}