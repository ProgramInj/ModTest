﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Wallet
{
    public class MoneyPrinter_2 : MoneyPrinter
    {
        public string printed { get; set; }

        public void print(string operation, string course, string amount)
        {
            printed = "# - " + operation + " - валюта: " + course + ", в количестве: " + amount;
        }
    }
}
