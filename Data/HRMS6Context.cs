using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HouseRentalManagementApp.Models;

namespace HRMS6.Data
{
    public class HRMS6Context : DbContext
    {
        public HRMS6Context (DbContextOptions<HRMS6Context> options)
            : base(options)
        {
        }

        public DbSet<HouseRentalManagementApp.Models.Booking>? Booking { get; set; }

        
    }
}
