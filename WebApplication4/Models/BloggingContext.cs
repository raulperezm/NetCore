using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebApplication4.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {
        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
        public DbSet<Post> Post { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Transfer> Transfer { get; set; }
    }
}
