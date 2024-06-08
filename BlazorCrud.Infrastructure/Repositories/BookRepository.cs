using BlazorCrud.Application.Interfaces;
using BlazorCrud.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BlazorCrudDbContext context;
        public BookRepository(IDbContextFactory<BlazorCrudDbContext> factory)
        {
            context = factory.CreateDbContext();
        }
    }
}
