using System.Linq;
using MyChild.Data.Models;

namespace MyChild.Data.Service
{
    public interface IBlogService
    {
        Blog AddBlog(Blog blog);
        int DeleteBlog(int id);
        Blog EditBlog(Blog blog);
        IQueryable<Blog> GetAllBlogs();
        Blog GetBlog(int id);
    }
}