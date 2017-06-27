using MyChild.Data.Models;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace MyChild.Data.Service
{
    public class AuthorService
    {
        private MyChildDbContext db = new MyChildDbContext();

        public Author AddAuthor(Author author)
        {
            if (author == null)
                throw new ArgumentNullException("passed in blog cannot be null");

            db.Author.Add(author);
            db.SaveChanges();

            return  author;
        }

        public List<Author> GetAuthors()
        {
            return db.Author.ToList();
        }

    }
}
