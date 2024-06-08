using BlazorCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Infrastructure.Context
{
    public class BlazorCrudDbContext : DbContext
    {
        public BlazorCrudDbContext(DbContextOptions<BlazorCrudDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
