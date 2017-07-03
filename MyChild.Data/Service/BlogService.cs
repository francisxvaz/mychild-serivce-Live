using MyChild.Data.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MyChild.Data.Service
{
    public class BlogService : IBlogService
    {
        private MyChildDbContext db = new MyChildDbContext();

        public IQueryable<Blog> GetAllBlogs()
        {
            return db.Blog.Include(x => x.Author).OrderByDescending(x => x.PublishDate);
        }

        public IQueryable<Blog> GetBlogsByPage(int numberOfBlogs, int pageNumber = 0)
        {
            if (numberOfBlogs <=0)
            {
                throw new ArgumentException("Tell me the total number of blogs to get");
            }

            if (pageNumber < 0)
            {
                pageNumber = 0;
            }

            return GetAllBlogs().Skip(numberOfBlogs * pageNumber).Take(numberOfBlogs);
        }

        public Blog GetBlog(int id)
        {
            Blog blog = db.Blog.Find(id);
            return blog;
        }

        
        public Blog AddBlog(Blog blog)
        {
            if (blog == null)
                throw new ArgumentNullException("passed in blog cannot be null");
                
            db.Blog.Add(blog);
            //db.SaveChanges();

            return blog;
        }

        public Blog EditBlog(Blog blog)
        {
           
            db.Entry(blog).State = EntityState.Modified;

            if (!BlogExists(blog.Id))
            {
                db.SaveChanges();
            }
            else
            {
                throw new ArgumentException(string.Format("No Blog with  Id {0} Found", blog.Id));
            }

            return blog;

        }


        public int DeleteBlog(int id)
        {
            var blog = GetBlog(id);

            db.Blog.Remove(blog);
            //return db.SaveChanges();
            return 0;
        }

        private bool BlogExists(int id)
        {
            return db.Blog.Count(e => e.Id == id) > 0;
        }
    }
}
