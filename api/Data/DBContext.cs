using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using api.Models;
using api.Data;

namespace api.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<User> Users {get; set;}
        public DbSet<Account> Accounts {get; set;}
        public DbSet<Transaction> Transactions {get; set;}
        public DbSet<Category> Categories {get; set;}
    }
}