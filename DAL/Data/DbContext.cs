using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext()
        {
        }
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }
        //thêm data set để lấy dât tuef csdl, vd:
        //public DbSet<Book> BooksList { get; set; }
    }
}
