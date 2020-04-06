using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Model
{
    public class BandMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string skill { get; set; }

    }
}