using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public class Account
	{
		public string AccountType { get; private set; }
		public string CustomerId { get; private set; }
		public string AccountNumber { get; private set; }
		public string AccountHolderName { get; private set; }
		public decimal Balance { get; private set; }


		public Account(Customer accountHolder, string accountType, string accountNumber) { 
			AccountType = accountType;
			Balance = 0;
			AccountNumber = accountNumber;
			CustomerId = accountHolder.CustomerId; 
		}


		public void Deposit(decimal depositAmount)
		{
			Balance += depositAmount;
		}

		public void Withdrawal(decimal withdrawalAmount)
		{
			Balance -= withdrawalAmount;
		}


	}
}
