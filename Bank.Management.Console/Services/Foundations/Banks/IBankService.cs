using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Management.Console.Services.Foundations.Banks
{
    internal interface IBankService
    {
        bool AddDeposit(decimal accountNumberForBank, decimal balance);
        decimal GetMoney(decimal accountNumberForBank, decimal balance);
        decimal GetBalanceInBank(decimal accountNumberForBank);
    }
}
