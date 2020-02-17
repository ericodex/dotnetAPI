using Microsoft.EntityFrameworkCore;

namespace DotNetAPI.Models
{
  public class TodoItem
  {
    public long Id { get; set;}
    public string Name { get; set;}
    public bool IsComplete {get; set;}
  }
}

namespace DotNetAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
        // TodoItems, Data Injection 
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}




