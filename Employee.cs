using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmitri
{
    abstract class Employee
    {
        protected string name;
        protected double fee;
        public Employee(string name,double fee )
        {
            this.name = name;
            this.fee = fee;
        }
        public  string Name
        {
            get { return name; }
        }
        public double Fee { get; set; }
        public abstract void WhatFee();
        public override string ToString()
        {
            return String.Format("Name : {0} , Fee : {1,3} .", name , fee);
        }
        //My GitHub Pribor86
    }
}
