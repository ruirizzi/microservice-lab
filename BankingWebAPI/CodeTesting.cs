using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingWebAPI.Models;

namespace BankingWebAPI
{
    public static class CodeTesting
    {
        public static void TestCode()
        {
            ValueTransfer vt = new ValueTransfer(1, 2, 324.67m);

            string a = vt.ToString();
        }
    }
}
