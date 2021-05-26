using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobileShopFinalAssesement.Models;

namespace MobileShopFinalAssesement.Data
{
    public class MobileShopFinalAssesementContext : DbContext
    {
        public MobileShopFinalAssesementContext (DbContextOptions<MobileShopFinalAssesementContext> options)
            : base(options)
        {
        }

        public DbSet<MobileShopFinalAssesement.Models.MobileName> MobileName { get; set; }

        public DbSet<MobileShopFinalAssesement.Models.Seller> Seller { get; set; }

        public DbSet<MobileShopFinalAssesement.Models.Buyer> Buyer { get; set; }
    }
}
