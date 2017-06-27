using MyChild.Data.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MyChild.Data.Service
{
    public class BlogService
    {
        private MyChildDbContext db = new MyChildDbContext();

        public IQueryable<Blog> GetAllBlogs()
        {
            return db.Blog.Include(x => x.Author);
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
            db.SaveChanges();

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

        private bool BlogExists(int id)
        {
            return db.Blog.Count(e => e.Id == id) > 0;
        }

        public int DeleteBlog(int id)
        {
            var blog = GetBlog(id);

            db.Blog.Remove(blog);
            return db.SaveChanges();

        }
    }
}
