using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank
{
	public class Bank
	{

		public string BankName { get; private set; }
		private List<Customer> _customerList = new List<Customer>();
		private List<Transaction> _transactionList = new List<Transaction>();

		public Bank(string name) {
			BankName = name;
		}

		public Customer AddCustomer(string name, string pin)
		{

			string customerId = Convert.ToString(_customerList.Count + 1);

			Customer newCustomer = new Customer( customerId,  name, pin);
			_customerList.Add(newCustomer);
			return newCustomer;
		}

		public Customer FindCustomerByName(string customerName)
		{
			return _customerList.Find(customer => customer.Name.Equals(customerName.ToUpper()));
		}
		public Transaction AddTransaction(Account fromAccount, Account toAccount, decimal amount)
		{

			string transactionId = Convert.ToString(_transactionList.Count + 1);

			Transaction newTransaction = new Transaction(transactionId, amount, fromAccount, toAccount);
			_transactionList.Add(newTransaction);
			return newTransaction;
		}

		public Transaction FindTransaction(string transactionId)
		{
			return _transactionList.Find(transaction  => transaction.TransactionId.Equals(transactionId));
		}
	}
}
