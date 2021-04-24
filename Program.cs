using System;

namespace Dmitri
{
    class Program
    {
        static void Main(string[] args)
        {
            HiredEmployee emp1 = new ("Dima",150);
            emp1.WhatFee();  //Fee per week : 150.
            emp1.FeeWithBonus(10.0); // Fee with bonus : 165 .
            HourEmployee emp2 = new ("Gleb", 5.6, 168);
            emp2.WhatFee(); // Fee is : 896 + 67,2 .
            PercentEmployee emp3 = new ("Denis",2000.0,10);
            emp3.WhatFee(); // Weekly fee from sales : 200 .
            CommissionEmployee emp4 = new ("Dan", 200.0, 15.0, 123456);
            emp4.WhatFee();  // Weekly fee : 200 + % from sales 18518,4 .
        }
    }
}
