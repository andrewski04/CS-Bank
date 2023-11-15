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
		public string AccountNumber { get; private set; }
		public string AccountHolderName { get; private set; }
		public decimal Balance { get; private set; }
		private string _pin;


		public Account(string accountHolderName, string accountType, string pin, string newAccountNumber) { 
			AccountType = accountType;
			AccountHolderName = accountHolderName;
			Balance = 0;
			AccountNumber = newAccountNumber;
			_pin = pin;
		}


		public void Deposit(decimal depositAmount)
		{
			Balance += depositAmount;
		}

		public void Withdrawal(decimal withdrawalAmount)
		{
			Balance -= withdrawalAmount;
		}

		public bool ValidatePIN(string pin)
		{
			if (pin == _pin) 
				return true;
			return false;
		}

	}
}
