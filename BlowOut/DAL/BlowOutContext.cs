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
    }
}