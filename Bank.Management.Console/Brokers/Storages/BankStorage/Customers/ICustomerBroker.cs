﻿//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Bank.Management.Console.Models;

namespace Bank.Management.Console.Brokers.Storages.BankStorage.Customers
{
    internal interface ICustomerBroker
    {
        bool CreateAccountNumberForClient(Customer customer);
        bool CloseAccountNumberForClient(decimal accountNumber);
        bool TransferMoneyBetweenAccounts(decimal firstAccountNumber, decimal secondAccountNumber, decimal money);
        string ReadAllCustormer();
        decimal GetBalance(decimal accountNumber);
    }
}
