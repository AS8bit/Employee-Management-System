using CRUD._02._10._24.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD._02._10._24.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }

    }
}
