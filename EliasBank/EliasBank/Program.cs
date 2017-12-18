using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliasBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank.CreateAllCustomersFromFile();
            Bank.CreateAllAccountsFromFile();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                GetMenu();
                GetChoice();
            }
        }

        private static void GetChoice()
        {
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                decimal totalValueOfBank = Bank.BankAccounts.Sum(p => p.Saldo);

                Console.WriteLine("This Bank has {0} Customers and {1} Accounts \nSum of Total money: {2}", Bank.BankCustomers.Count(), Bank.BankAccounts.Count(), totalValueOfBank);
                Console.WriteLine("\n\n\nThanks for using EliasBank, presented by Elias\n\n\nPress Enter to save and exit...");
                Console.ReadLine();
                Bank.SaveToFile();

                Environment.Exit(0);
            }
            if (choice == "2")
            {
                SearchForCustomer();
            }
            if (choice == "3")
            {
                ShowCustomer();
            }
            if (choice == "4")
            {
                Bank.CreateCustomer();
            }
            if (choice == "5")
            {
                Bank.DeleteCostumer();
            }
            if (choice == "6")
            {
                Bank.CreateAccount();
            }
            if (choice == "7")
            {
                Bank.DeleteAccount();
            }
            if (choice == "8")
            {
                Bank.Deposit();
            }
            if (choice == "9")
            {
                Bank.Withdrawl();
            }
            if (choice == "10")
            {
                Bank.Transfer();
            }
        }

        public static void ShowCustomer()
        {
            Console.Clear();
            Console.WriteLine("Do you want to search with Customer ID [1] or AccountNumber [2]\nPress 1 or 2");
            string choice = Console.ReadLine();

            bool cantFindAny = true;
            decimal total = 0;

            if (choice=="1")
            {
                Console.WriteLine("Input CustomerID\n");
                var input = Console.ReadLine();

                foreach (var item in Bank.BankCustomers)
                {
                    if (item.CustomerId == input)
                    {
                        Console.WriteLine("KundNummer: " + input);
                        Console.WriteLine("Kundnamn: {0}\nOrganisationsnummer: {1}\nAdress:{2} {3} {4}\n", item.Name, item.OrgNumber, item.Adress, item.AreaCode, item.City);
                        cantFindAny = false;

                        foreach (var acc in Bank.BankAccounts)
                        {
                            if (acc.CustomerId == input)
                            {
                                Console.WriteLine("Account id: {0}\nSaldo: {1}", acc.AccountNumber, acc.Saldo);
                                total += acc.Saldo;
                            }
                        }
                    }
                }

            }
            else if (choice=="2")
            {
                Console.WriteLine("Input Accountnumber\n");
                var input = Console.ReadLine();

                foreach (var item in Bank.BankAccounts)
                {
                    if (input == item.AccountNumber)
                    {
                        foreach (var cust in Bank.BankCustomers)
                        {
                            if (cust.CustomerId == item.CustomerId)
                            {
                                Console.WriteLine("KundNummer: " + item.CustomerId);
                                Console.WriteLine("Kundnamn: {0}\nOrganisationsnummer: {1}\nAdress:{2} {3} {4}\n", cust.Name, cust.OrgNumber, cust.Adress, cust.AreaCode, cust.City);
                                cantFindAny = false;
                            }
                        }

                        Console.WriteLine("Account id: {0}\nSaldo: {1}", item.AccountNumber, item.Saldo);
                        total += item.Saldo;
                    }
                }
            }
            
            if (cantFindAny == true)
            {
                Console.WriteLine("No customer nor account found...");
            }

            if (total > 0)
            {
                Console.WriteLine("\n\nTotal sum: " + total);
            }

            Console.WriteLine("\nPress any key to get to menu");
            Console.ReadLine();
        }
        public static void SearchForCustomer()
        {
            Console.Clear();
            Console.WriteLine("Search for customer\nYou can use name or city.");
            var input = Console.ReadLine();
            bool cantFindAnything = true;

            foreach (var item in Bank.BankCustomers)
            {
                if (item.Name.ToUpper().Contains(input.ToUpper()) || item.City.ToUpper().Contains(input.ToUpper()))
                {
                    Console.WriteLine("Customer ID: {0}\nCustomer Name:{1}\nCity: {2}", item.CustomerId, item.Name, item.City);
                    cantFindAnything = false;
                }
            }

            if (cantFindAnything == true)
            {
                Console.WriteLine("Can't find any customer with your input.");
            }

            Console.WriteLine("\nPress any key to get to menu");
            Console.ReadLine();
        }

        private static void GetMenu()
        {
            Console.Clear();

            decimal totalValueOfBank = Bank.BankAccounts.Sum(p => p.Saldo);

            Console.WriteLine("Welcome to the EliasBank\n");
            Console.WriteLine("This Bank has {0} Customers and {1} Accounts \nSum of Total money: {2}", Bank.BankCustomers.Count(), Bank.BankAccounts.Count(), totalValueOfBank);

            Console.WriteLine("\nWhat do you want to do. Choose number and press enter for choice.\n");
            string[] Menu = new string[] { "1.Save and quit", "2.Search for Customer", "3.Show Customer", "4.Create Customer", "5.Delete Customer", "6.Create Account", "7.Delete Account", "8.Deposit", "9.Withdrawl", "10.Transfer" };
            for (int i = 0; i < Menu.Length; i++)
            {
                Console.WriteLine(Menu[i]);
            }
        }
    }
}
