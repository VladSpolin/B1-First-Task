
namespace FirstTask
{
    public class LineService
    {
        private readonly ApplicationContext _context = new ApplicationContext();

        public  void Create(Line line)
        {
                _context.Lines.Add(line); //imports line into database
            _context.SaveChanges();
        }
    }
}
