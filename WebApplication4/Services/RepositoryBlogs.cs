using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class RepositoryBlogs : IRepositoryBlogs
    {
        private readonly BloggingContext _DBblogs;
        public RepositoryBlogs (BloggingContext DBblogs)
        {
            this._DBblogs = DBblogs;
        }

        public IEnumerable<Blog> List ()
        {
            return _DBblogs.Blog;
        }
        
    }
}
