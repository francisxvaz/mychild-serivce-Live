using System.Collections.Generic;
using MyChild.Data.Models;

namespace MyChild.Data.Service
{
    public interface IAuthorService
    {
        Author AddAuthor(Author author);
        List<Author> GetAuthors();
    }
}