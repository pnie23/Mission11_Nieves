namespace Mission11_Nieves.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private BookContext _context;

        public EFBooksRepository(BookContext temp)
        {
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
