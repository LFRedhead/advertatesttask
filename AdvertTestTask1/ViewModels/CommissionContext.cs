using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdvertTestTask1.ViewModels;
using Microsoft.Extensions.Configuration;


namespace AdvertTestTask1.ViewModels
{
    public class CommissionContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public CommissionContext(DbContextOptions<CommissionContext> options)
        : base(options)
    {
           
        }
    }
}
