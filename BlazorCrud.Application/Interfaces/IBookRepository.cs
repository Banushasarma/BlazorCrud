﻿using BlazorCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(int id);

        Task UpdateAsync(Book book);
        Task DeleteIdAsync(int id);
    }
}
