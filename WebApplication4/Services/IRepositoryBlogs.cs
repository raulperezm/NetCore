using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    interface IRepositoryBlogs
    {
        IEnumerable<Blog> List();
    }
}
