
using System.Data.Entity;

namespace FirstTask
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext():base("DefaultConnection") //Connection String from app.config
        { }
        
        public DbSet<Line> Lines { get; set; }
    }
}
