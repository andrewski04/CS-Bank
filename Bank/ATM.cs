using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	// ATM class allows users to interface with a specific bank and check account status
	 public class ATM
	{
		private Bank _bank { get; set; }
		public ATM(Bank bank) {
			_bank = bank;
		}

		//Main method that runs the ATM user interface
		public void Run()
		{

			//search user accounts from name input
			int i = 0;
			Customer currentCustomer = null;
			while (currentCustomer is null) {
				Console.Clear();
				Console.WriteLine("Welcome to the official ATM of " + _bank.BankName + "!\n");
				if (currentCustomer is null && i > 0) Console.WriteLine("Account not found!");
				Console.Write("Please enter your name: ");
				currentCustomer = _bank.FindCustomerByName(Console.ReadLine());
				i++;
            }

			//Validate users pin number
			bool isValidated = true;
			do
			{
				Console.Clear();
				Console.WriteLine("Hello, " + currentCustomer.Name + "!\n");
				if (!isValidated) Console.WriteLine("Invalid pin! Try again.");
				Console.Write("Please enter your pin: ");
				isValidated = currentCustomer.ValidatePIN(Console.ReadLine());
			} while (!isValidated);

			// prints customer details and accounts when successful
			Console.Clear();
			PrintUtil.PrintCustomerDetails(currentCustomer);
			


		}





	}
}
