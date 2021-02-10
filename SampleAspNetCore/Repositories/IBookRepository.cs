using SampleAspNetCore.Models;
using System.Collections.Generic;

namespace SampleAspNetCore.Repositories
{
    public interface IBookRepository
    {
        int AddBook(BookModel book);
        List<BookModel> GetAllBooks();
    }
}