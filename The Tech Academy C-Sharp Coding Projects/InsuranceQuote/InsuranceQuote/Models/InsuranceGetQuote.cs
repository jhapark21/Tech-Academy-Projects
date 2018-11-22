using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace InsuranceQuote.Models
{
    public class InsuranceGetQuote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int Ticket { get; set; }
        public Boolean DUI { get; set; }
        public Boolean FullCover { get; set; }
        public float QuotePrice { get; set; }
    }
}