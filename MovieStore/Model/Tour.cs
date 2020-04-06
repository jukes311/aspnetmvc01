using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStore.Model
{
    public class Tour
    {
        public string code { get; set; }
        public DateTime tourDate { get; set; }
        public string name { get; set; }
        public string venue { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public int capacity { get; set; }
        public double price { get; set; }
    }
}