using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ApiDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Country { get; set; }



        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options)
        {

        }
        public ApiDBContext() { }
    }
}
