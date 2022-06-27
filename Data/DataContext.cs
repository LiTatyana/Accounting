namespace Accounting.Data
{
    public class DataContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
    }
}
