using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BlowOut.Models;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int iInstrumentID { get; set; }
        public string sInstrumentDesc { get; set; }
        public bool bInstrumentType  { get; set; }
        public decimal dInstrumentPrice { get; set; }
        public int? iCustomerID { get; set; }


    }
}