﻿using Entities.Entities;
using Repositories.IRepositories;

namespace Repositories.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly APIContext _apiContext;

        public BookRepository(APIContext apiContext)
        {
            _apiContext = apiContext;
        }

        public void SaveBook(Book book)
        {
            _apiContext.Add(book);
            _apiContext.SaveChanges();
        }

        public List<Book> GetBooks()
        {
            var books = _apiContext.Books.ToList();

            return books;
        }
    }
}