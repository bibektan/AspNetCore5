using BiTanBookStore.Model;
using System.Collections.Generic;
using System.Linq;

namespace BiTanBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel() { Id=1,Title = "mvc", Author = "sarthak"},
                new BookModel() { Id=2,Title = "ASP.NET core", Author = "bibek"},
                new BookModel() { Id=3,Title = "hooked", Author = "pappu"},
                new BookModel() { Id=4,Title = "contaginous", Author = "bebib"},
                new BookModel() { Id=5,Title = "php", Author = "kebib"}
            };
        }

    }
}
