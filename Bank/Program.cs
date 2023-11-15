using System.Reflection.Metadata.Ecma335;

namespace Bank
{
	public class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run)
			{
				List<Bank> banks = new List<Bank>();
				banks.Add(createTestBank("DrewskiBank"));
				banks.Add(createTestBank("BruhBank"));

				Console.WriteLine("Welcome to the official ATM of DrewskiBank");
				Console.WriteLine("Please select the bank your account is under");

				for (int i = 0; i < banks.Count; i++)
				{
					Console.WriteLine(i + 1 + ". " + banks[i].Name);
				}

				Console.Write("\nEnter number: ");
				Bank bank = banks[Convert.ToInt32(Console.ReadLine()) - 1];

				Console.Clear();
				Console.WriteLine("\nEnter your account number: ");
				Account account = bank.FindAccount(Console.ReadLine());
				Console.WriteLine("\nEnter you pin: ");
				if (account.ValidatePIN(Console.ReadLine()))
				{
					printAccountDetails(account);
				}
				else
				{
					Console.WriteLine("Auth failed");
				}

				Console.WriteLine("Press enter to restart or any key then enter to quit");
				if(Console.Read != null)
				{
					run = false;
				}

			}
		}

		static Bank createTestBank(string name)
		{
			Bank testBank = new Bank(name);
			testBank.CreateAccount("Andrew", "Checking", "1234");
			testBank.CreateAccount("Andrew", "Savings", "1234");
			testBank.CreateAccount("Drew", "Savings", "1234");
			testBank.CreateAccount("Andy", "Checking", "1234");
			return testBank;
		}

		static void printAccountDetails(Account account)
		{
			Console.WriteLine("Account number: " + account.AccountNumber);
			Console.WriteLine("Account holder: " + account.AccountHolderName);
			Console.WriteLine("Account amount: " + account.Balance);
			Console.WriteLine("Account type: " + account.AccountType);
		}

		static void printTransactionDetails(Transaction transaction)
		{
			Console.WriteLine("Transaction ID: " + transaction.TransactionId);
			Console.WriteLine("From Account #: " + transaction.FromAccount.AccountNumber);
			Console.WriteLine("To Account #: " + transaction.ToAccount.AccountNumber);
			Console.WriteLine("Amount: " + transaction.TransactionAmount);
			Console.WriteLine("Transaction Status: " + transaction.Status); 
		}
	}
}