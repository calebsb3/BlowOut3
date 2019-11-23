using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlowOut.Models;
using System.Data.Entity;

namespace BlowOut.DAL
{
    public class BlowOutContext : DbContext
    {
        public BlowOutContext()
            : base("BlowOutContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet< Instrument> Instruments { get; set; }
    }
}