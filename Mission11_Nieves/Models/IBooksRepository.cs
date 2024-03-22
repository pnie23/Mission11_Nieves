namespace Mission11_Nieves.Models
{
    public interface IBooksRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
