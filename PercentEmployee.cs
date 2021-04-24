using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri
{
    class PercentEmployee : Employee
    {
        protected double percent;
        public PercentEmployee(string name , double fee , double percent):base(name,fee)
        {
            this.percent = percent;
        }
        public double Percent { get; set; }
        public override void WhatFee()
        {
            Console.WriteLine("Fee from sales  : {0,3} .",fee*percent/100);
        }
    }
}
