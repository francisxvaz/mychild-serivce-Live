using MyChild.Data.Models;
using MyChild.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mychild_service.Controllers
{
    public class BlogController : ApiController
    {
        // GET: api/Blog
        public IEnumerable<Blog> Get()
        {
            return new BlogService().GetAllBlogs();
        }

        // GET: api/Blog/5
        public Blog Get(int id)
        {
            return new BlogService().GetBlog(id);
        }

        // POST: api/Blog
        public void Post([FromBody]Blog blog)
        {
            new BlogService().AddBlog(blog);
        }

        // PUT: api/Blog/5
        public void Put(int id, [FromBody]Blog blog)
        {
            new BlogService().EditBlog(blog);
        }

        // DELETE: api/Blog/5
        public void Delete(int id)
        {
            new BlogService().DeleteBlog(id);
        }
    }
}
