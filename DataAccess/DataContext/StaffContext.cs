using FashionStaff.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FashionStaff.DataAccess.DataContext
{
    public class StaffContext : DbContext
    {
        public DbSet<Staff> staff { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =DESKTOP-51I20UV\\SQLEXPRESS;Database = FashionStaff ; Integrated Security =True; Connect Timeout = 30; Encrypt =True; Trust Server Certificate =True; Application Intent = ReadWrite;Multi Subnet Failover =False");
        }
    }
}
