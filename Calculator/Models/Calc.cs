using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Calculator.Models
{
    public class Calc
    {
        public int id { get; set; }
        public string input1 { get; set; }
        public string input2 { get; set; }
        public string arithmetic { get; set; }
        public float result { get; set; }
    }

    public class CalcContext : DbContext
    {
        public DbSet<Calc> calc { get; set; }
    }
}