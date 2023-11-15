using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	public class Transaction
	{
		public string TransactionId { get; private set; }
		public decimal TransactionAmount { get; private set; }
		public Account FromAccount { get; private set; }
		public Account ToAccount { get; private set; }
		public string Status { get; private set; }


		public Transaction(string transactionId, decimal transactionAmount, Account fromAccount, Account toAccount)
		{
			TransactionId = transactionId;
			TransactionAmount = transactionAmount;
			FromAccount = fromAccount;
			ToAccount = toAccount;
			Status = "Incomplete";
		}

		public void Execute ()
		{
			FromAccount.Withdrawal(TransactionAmount);
			ToAccount.Deposit(TransactionAmount);
			Status = "Complete";
		}

	}

}
