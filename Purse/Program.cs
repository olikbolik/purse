﻿using System;

namespace Purse
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = new Money.Money(100);
            Console.WriteLine(money.GetMoney());    
        }
    }
}
