﻿//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

namespace Bank.Management.Console.Brokers.Storages.Bank
{
    internal interface IBankStorageBroker
    {
        bool MakingDeposit(decimal accountNumberForBank, decimal balance);
        decimal WithdarwMoney(decimal accountNumberForBank, decimal balance);
        decimal GetBalance(decimal accountNumberForBank);
    }
}