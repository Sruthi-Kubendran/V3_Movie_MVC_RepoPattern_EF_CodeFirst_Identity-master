using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Models;

namespace V3_Movie_MVC_RepoPattern_EF_CodeFirst_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        internal object Entry<T>()
        {
            throw new NotImplementedException();
        }
    }
}
