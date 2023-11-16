using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public class Customer
	{

		public String CustomerId { get; private set; }
		public String Name { get; set; }
		public List<Account> AccountList { get; private set; }
		private string _pin;


		public Customer(string customerId, string name, string pin)
		{
			CustomerId = customerId;
			Name = name.ToUpper();
			AccountList = new List<Account>();
			_pin = pin;
		}

		public Account AddAccount(string accountType)
		{
			string accountNumber = Convert.ToString(AccountList.Count + 1);

			Account newAccount = new Account(this, accountType, accountNumber);
			AccountList.Add(newAccount);
			return newAccount;
		}

		public Account FindAccount(string accountNumber)
		{
			return AccountList.Find(x => x.AccountNumber.Equals(accountNumber));
		}

		public bool ValidatePIN(string pin)
		{
			if (pin == _pin)
				return true;
			return false;
		}
	}
}
