using SampleAspNetCore.Models;
using System.Collections.Generic;

namespace SampleAspNetCore.Repositories
{
    public class BookRepository : IBookRepository
    {
        /// <summary>
        /// Hold in-memory books data
        /// </summary>
        private List<BookModel> books = new List<BookModel>();

        /// <summary>
        /// Add a new book in the books list
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Id of new book</returns>
        public int AddBook(BookModel book)
        {
            book.Id = books.Count + 1; // Create the incremental Id
            books.Add(book);
            return book.Id;
        }

        /// <summary>
        /// Gets all books
        /// </summary>
        /// <returns>All books</returns>
        public List<BookModel> GetAllBooks()
        {
            return books;
        }

    }
}
