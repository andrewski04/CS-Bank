using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	static public class PrintUtil
	{
		public static void PrintAccountDetails(Account account)
		{
			Console.WriteLine("Account number: " + account.AccountNumber);
			Console.WriteLine("Account amount: " + account.Balance);
			Console.WriteLine("Account type: " + account.AccountType);
		}

		public static void PrintCustomerDetails(Customer customer)
		{
			Console.WriteLine("Customer ID: " + customer.CustomerId);
			Console.WriteLine("Customer Name: " + customer.Name);
			Console.WriteLine("Accounts: ");

			int i = 1;
			foreach (Account account in customer.AccountList) {
				Console.WriteLine("\nAccount #" + i);
				PrintAccountDetails(account);
				Console.WriteLine();
				i++;
			}
		}


		public static void PrintTransactionDetails(Transaction transaction)
		{
			Console.WriteLine("Transaction ID: " + transaction.TransactionId);
			Console.WriteLine("From Account #: " + transaction.FromAccount.AccountNumber);
			Console.WriteLine("To Account #: " + transaction.ToAccount.AccountNumber);
			Console.WriteLine("Amount: " + transaction.TransactionAmount);
			Console.WriteLine("Transaction Status: " + transaction.Status);
		}
	}
}
