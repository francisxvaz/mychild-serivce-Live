using MyChild.Data.Models;
using MyChild.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mychild.service.Controllers
{
    public class BlogController : ApiController
    {
        private IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public BlogController()
        {
            _blogService = new BlogService();
        }

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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Blog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Blog/5
        public void Delete(int id)
        {
        }
    }
}
