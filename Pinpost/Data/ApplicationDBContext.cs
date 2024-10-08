using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pinpost.models;

namespace Pinpost.data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }


        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }


    }
}