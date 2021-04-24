using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri
{
    class HourEmployee : Employee
    {
        protected double time;
        public HourEmployee(string name, double fee, double time) : base(name,fee)
        {
            this.fee = fee;
            if (time <= 168)
            {
                this.time = time;
            }
            else
            {
                this.time = 168;
            }
        }
        public double Time { set; get; }
        public override void WhatFee()
        {
            if (time > 160 && time <= 168)
            {
                Console.WriteLine("Fee is : {0,3} + Bonus {1,3} .", Math.Round((fee * 160),2), Math.Round((1.5 * (time - 160) * fee), 2));
            }
            else 
            {
                Console.WriteLine("Fee is : {0,3} .", fee * time);
            }
        }   
    }
}
