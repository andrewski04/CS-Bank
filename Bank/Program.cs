using System.Reflection.Metadata.Ecma335;

namespace Bank
{
	public class Program
	{
		static void Main(string[] args)
		{

			//creates a new banks and adds 2 hard coded test banks with users and accounts
			List<Bank> banks = new List<Bank>();
			banks.Add(createTestBank("AndrewBank"));
			banks.Add(createTestBank2("RealBank"));

			// initializes new atm interfaced to specific bank in list
			ATM atm = new ATM(banks[0]);
			atm.Run();

		}

		static public Bank createTestBank(string name)
		{
			Bank testBank = new Bank(name);
			Customer customer1 = testBank.AddCustomer("Andrew Houser", "1234");
			Customer customer2 = testBank.AddCustomer("Le Bruh", "1234");
			Account account1 = customer1.AddAccount("checkings");
			Account account2 = customer1.AddAccount("savings");
			Account account3 = customer2.AddAccount("savings");
			account1.Deposit((decimal)12.23);
			account2.Deposit((decimal)2349.12);
			account3.Deposit((decimal)12.23);

			return testBank;
		}
		static public Bank createTestBank2(string name)
		{
			Bank testBank = new Bank(name);
			Customer customer1 = testBank.AddCustomer("Andrew Jr", "1234");
			Customer customer2 = testBank.AddCustomer("John", "1234");
			Account account1 = customer1.AddAccount("checkings");
			Account account2 = customer2.AddAccount("savings");
			account1.Deposit((decimal)15.23);
			account2.Deposit((decimal)1023.24);
			return testBank;
		}
		

	}
}