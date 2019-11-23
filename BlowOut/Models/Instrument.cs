using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Instrument Name")]
        public string sInstrumentDesc { get; set; }

        [DisplayName("Instrument Type")]
        public bool bInstrumentType  { get; set; }

        [DisplayName("Price")]
        public decimal dInstrumentPrice { get; set; }

        public int? iCustomerID { get; set; }

        public string sImageFileName { get; set; }

    }
}