using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entity
{
    public class GvResourceContextFactory : IDesignTimeDbContextFactory<GvResourceContext>
    {
        public GvResourceContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GvResourceContext>();
            optionsBuilder.UseSqlServer("Data Source=ANDEV\\SQLEXPRESS01;Initial Catalog=GvResourceProDB;Integrated Security=True");

            return new GvResourceContext(optionsBuilder.Options);
        }
    }
}
