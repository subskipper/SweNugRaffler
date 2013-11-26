using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SweNugRaffler.Models
{
    public class ContestantEntryModel
    {
        [DisplayName("Full Name:")]
        public string FullName { get; set; }
        [DisplayName("E-Mail (no spam, promise!):")]
        public string Email { get; set; }
        [DisplayName("Company (optional):")]
        public string Company { get; set; }
    }
}