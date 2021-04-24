using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri
{
    class HiredEmployee : Employee
    {
        public HiredEmployee(string name, double fee):base(name,fee)
        {
            
        }
        public void FeeWithBonus(double i)
        {
            Console.WriteLine("Fee with bonus : {0,3} .", i / 100 * fee + fee);
        }
        public override void WhatFee()
        {
            Console.WriteLine("Fee per week : {0,3} .",fee);
        }
    }
}
