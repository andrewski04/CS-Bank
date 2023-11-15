using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank
{
	internal class Bank
	{

		public string Name { get; private set; }
		private List<Account> _accountList = new List<Account>();
		private List<Transaction> _transactionList = new List<Transaction>();

		public Bank(string name) {
		Name = name;
		}

		public Account CreateAccount(string accountHolderName, string accountType, string pin)
		{
			string accountNumber = "00000" + Convert.ToString(_accountList.Count + 1);

			Account newAccount = new Account(accountHolderName,  accountType, pin, accountNumber);
			_accountList.Add(newAccount);
			return newAccount;
		}
		public Account FindAccount(string accountNumber) {
			return _accountList.Find(x => x.AccountNumber.Equals(accountNumber));
		}


		public Transaction CreateTransaction(Account fromAccount, Account toAccount, decimal amount)
		{

			string transactionId = "00000" + Convert.ToString(_transactionList.Count + 1);

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
