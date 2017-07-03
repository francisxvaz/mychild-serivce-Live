using MyChild.Data.Models;
using MyChild.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace mychild.service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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


        public IEnumerable<Blog> GetAll()
        {
            return new BlogService().GetAllBlogs();
        }

        //public IEnumerable<Blog> Get(int pageLength, int pageNumber = 0)
        //{
        //    return new BlogService().GetBlogsByPage(pageLength, pageNumber);
        //}


        public Blog GetById(int id)
        {
            return new BlogService().GetBlog(id);
        }

        public void Post([FromBody]Blog blog)
        {
            new BlogService().AddBlog(blog);
        }

        
        public void Put(int id, [FromBody]Blog blog)
        {
            new BlogService().EditBlog(blog);
        }

        
        public void Delete(int id)
        {
            new BlogService().DeleteBlog(id);
        }
    }
}
