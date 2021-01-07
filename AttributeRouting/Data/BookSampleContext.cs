using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AttributeRouting.Model;

namespace AttributeRouting.Data
{
    public class BookSampleContext : DbContext
    {
        public BookSampleContext (DbContextOptions<BookSampleContext> options)
            : base(options)
        {
        }

        public DbSet<AttributeRouting.Model.Book> Book { get; set; }
    }
}
