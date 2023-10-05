namespace TH01.Models
{
    public class DataContext: Dbcontext
    {
        public DataContext(DbcontextOption<DataContext> option) : base(option)
        {
        }
        public DbSet<Menu> Menus { get; set }
            }
}
