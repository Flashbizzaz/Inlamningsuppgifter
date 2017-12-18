using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace EliasBank
{
    class Bank
    {
        public static List<Customer> BankCustomers { get => _bankCustomers; set => _bankCustomers = value; }
        public static List<Account> BankAccounts { get => _bankAccounts; set => _bankAccounts = value; }

        static List<Customer> _bankCustomers = new List<Customer>();
        static List<Account> _bankAccounts = new List<Account>();



        public static List<string> ListWholeFile()
        {
            var dir = new DirectoryInfo(@"C:\Users\elias\source\repos\EliasBank\Testdata-Uppgift3\");

            var textFile = (from f in dir.GetFiles()
                            orderby f.LastWriteTime descending
                            select f).First().ToString();

            //var path = @"C:\Users\elias\source\repos\EliasBank\Testdata-Uppgift3\bankdata.txt";

            StreamReader bankfilen = new StreamReader(dir + textFile);

            List<string> customerList = new List<string>();

            string line;
            while ((line = bankfilen.ReadLine()) != null)
            {
                customerList.Add(line);
            }
            bankfilen.Close();

            return customerList;
        }

        public static void CreateAllCustomersFromFile()
        {
            List<string> wholeTextFile = ListWholeFile();

            foreach (var item in wholeTextFile)
            {
                string[] arraydList = item.Split(';').ToArray();
                if (arraydList.Length > 4)
                {
                    Customer cust = new Customer()
                    {
                        CustomerId = arraydList[0],
                        OrgNumber = arraydList[1],
                        Name = arraydList[2],
                        Adress = arraydList[3],
                        City = arraydList[4],
                        Region = arraydList[5],
                        AreaCode = arraydList[6],
                        Country = arraydList[7],
                        Phone = arraydList[8],
                    };

                    _bankCustomers.Add(cust);
                }
            }
        }
        public static void CreateAllAccountsFromFile()
        {
            List<string> wholeTextFile = ListWholeFile();

            foreach (var item in wholeTextFile)
            {
                string[] arraydList = item.Split(';').ToArray();

                if (arraydList.Length == 3)
                {
                    decimal convertedValue = decimal.Parse(arraydList[2], CultureInfo.InvariantCulture);

                    Account acc = new Account()
                    {
                        AccountNumber = arraydList[0],
                        CustomerId = arraydList[1],
                        Saldo = convertedValue
                    };

                    _bankAccounts.Add(acc);

                }


            }
        }
        public static void SaveToFile()
        {
            string path = @"C:\Users\elias\source\repos\EliasBank\Testdata-Uppgift3\" + DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt";

            int customerCount = _bankCustomers.Count();
            int accountCount = _bankAccounts.Count();

            using (StreamWriter newTextFile = new StreamWriter(File.Create(path)))
            {
                newTextFile.WriteLine(customerCount.ToString());

                foreach (var item in _bankCustomers)
                {
                    newTextFile.WriteLine(
                        item.CustomerId + ";" +
                        item.OrgNumber + ";" +
                        item.Name + ";" +
                        item.Adress + ";" +
                        item.City + ";" +
                        item.Region + ";" +
                        item.AreaCode + ";" +
                        item.Country + ";" +
                        item.Phone);
                }

                newTextFile.WriteLine(accountCount.ToString());

                foreach (var item in _bankAccounts)
                {
                    newTextFile.WriteLine(
                        item.AccountNumber + ";" +
                        item.CustomerId + ";" +
                        item.Saldo.ToString(CultureInfo.InvariantCulture));
                }
                newTextFile.Close();
            }
        }

        public static void Deposit()
        {
            Console.Clear();
            Console.WriteLine("Print accountnumber you want to put in money in");
            string input = Console.ReadLine();
            bool noAccount = false;

            decimal inputMoney = 0;
            string inputMString = "";

            foreach (var item in _bankAccounts.ToList())
            {
                if (input == item.AccountNumber)
                {
                    noAccount = true;
                    if (noAccount == true)
                    {
                        Console.WriteLine("\nHow much?\n\nExempel: 1500,50");
                        inputMString = Console.ReadLine();

                        if (Decimal.TryParse(inputMString, out inputMoney))
                        {
                            foreach (var acc in _bankAccounts.ToList())
                            {
                                if (input == acc.AccountNumber)
                                {
                                    decimal newValue = acc.Saldo + inputMoney;
                                    acc.Saldo = newValue;
                                    Console.WriteLine("Account: {0}\nNew balance:{1}", acc.AccountNumber, acc.Saldo);
                                    Console.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No deposit.\nDid you type amount money to deposit in the right form?");
                        }
                    }
                }
            }

            if (noAccount == false)
            {
                Console.WriteLine("Cant find account. Did you type accountnumber in correctly. Your input: " + input);
            }

            Console.WriteLine("\nPress any key too continue");
            Console.ReadLine();

        }
        public static void Transfer()
        {
            Console.Clear();

            Console.Write("Accountnumber you want to withdrawl money from: ");
            string inputFromAccount = Console.ReadLine();
            Console.Write("Too which account: ");
            string inputToAccount = Console.ReadLine();
            Console.Write("\nExempel:1500,50\n\nHow much?: ");
            string inputMString = Console.ReadLine();

            decimal moneyTransfer = 0;
            bool enoughDough = true;
            bool fromAccount = true;
            bool toAccount = true;

            foreach (var item in _bankAccounts)
            {
                if (item.AccountNumber == inputFromAccount)
                {
                    fromAccount = false;
                }
            }
            foreach (var item in _bankAccounts)
            {
                if (item.AccountNumber == inputToAccount)
                {
                    toAccount = false;
                }
            }

            if (Decimal.TryParse(inputMString, out moneyTransfer))
            {
                if (toAccount == false && fromAccount == false)
                {
                    foreach (var item in _bankAccounts.ToList())
                    {
                        if (inputFromAccount == item.AccountNumber)
                        {
                            if (moneyTransfer <= item.Saldo)
                            {
                                decimal newValue = item.Saldo - moneyTransfer;
                                item.Saldo = newValue;
                                Console.WriteLine("Account {0}\n New Balance: {1}", item.AccountNumber, item.Saldo);
                            }
                            else
                            {
                                Console.WriteLine("You do not have enough money on account");
                                enoughDough = false;
                            }
                        }
                    }

                    if (enoughDough == true)
                    {
                        foreach (var item in _bankAccounts.ToList())
                        {
                            if (inputToAccount == item.AccountNumber)
                            {
                                decimal newValue = item.Saldo + moneyTransfer;
                                item.Saldo = newValue;
                                Console.WriteLine("Account: {0}\nNew balance:{1}", item.AccountNumber, item.Saldo);
                                Console.ReadLine();
                            }
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("No Transfer.\nDid you type in amount money correctly");
            }
            if (toAccount == true)
            {
                Console.WriteLine("No Transfer.\nBank has no accunt with accountnumber: " + inputToAccount);
            }
            if (fromAccount == true)
            {
                Console.WriteLine("No Transfer.\nBank has no accunt with accountnumber: " + inputFromAccount);
            }

            Console.WriteLine("\nPress any key too continue");
            Console.ReadLine();
        }
        public static void Withdrawl()
        {
            Console.Clear();
            Console.WriteLine("Accountnumber you want to withdrawl from");
            string input = Console.ReadLine();

            decimal withdrawlMoney = 0;
            Console.WriteLine("\nExempel: 1500,50\n\nHow much?");
            string inputMString = Console.ReadLine();

            if (Decimal.TryParse(inputMString, out withdrawlMoney))
            {
                foreach (var item in _bankAccounts.ToList())
                {
                    if (input == item.AccountNumber)
                    {
                        if (withdrawlMoney <= item.Saldo)
                        {
                            decimal newValue = item.Saldo - withdrawlMoney;
                            item.Saldo = newValue;

                            Console.WriteLine("Account: {0}\nNew balance:{1}", item.AccountNumber, item.Saldo);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("You do not have enough money on account");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Did you type in amount money in the right form?");
            }

            Console.WriteLine("\nPress any key too continue");
            Console.ReadLine();
        }


        public static void DeleteAccount()
        {
            Console.Clear();
            Console.Write("Input account number for account you want to delete:");
            string input = Console.ReadLine();

            bool notPossible = false;
            bool cantFindAcount = false;

            foreach (var item in _bankAccounts.ToList())
            {
                if (item.AccountNumber == input && item.Saldo == 0)
                {
                    Console.WriteLine("Account {0} succesfully deleted", item.AccountNumber);
                    _bankAccounts.Remove(item);
                }
                else if (item.AccountNumber == input && item.Saldo != 0)
                {
                    notPossible = true;
                }
                else if (item.AccountNumber != input)
                {
                    cantFindAcount = true;
                }
            }

            if (notPossible == true)
            {
                Console.WriteLine("Account have money on it. It is not possible to delete an account while their is money in it");
            }
            if (cantFindAcount == true)

            {
                Console.WriteLine("Cant find account with accountnumber: " + input);
            }


            Console.WriteLine("\nPress any key too continue");
            Console.ReadLine();

        }
        public static void CreateAccount()
        {
            Console.Clear();
            Console.WriteLine("Create Account\nRight down CustomerId for person you want to create a new account");
            string idInput = Console.ReadLine();

            var newId = AccountIdMethod();
            bool wrongID = true;

            foreach (var item in _bankCustomers.ToList())
            {
                if (idInput == item.CustomerId)
                {
                    Account acc = new Account()
                    {
                        CustomerId = idInput,
                        AccountNumber = newId,
                    };

                    _bankAccounts.Add(acc);
                    wrongID = false;
                    Console.WriteLine("New account created. Accountnumber: {0}", newId);
                }
            }

            if (wrongID == true)
            {
                Console.WriteLine("No customer found");
            }

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
        }
        public static void DeleteCostumer()
        {
            Console.Clear();
            Console.WriteLine("Input idnumber for customer you want to delete");
            string input = Console.ReadLine();

            int accountsWithMoney = 0;
            bool customerExist = false;

            foreach (var item in _bankCustomers.ToList())
            {
                if (item.CustomerId == input)
                {
                    customerExist = true;
                }
            }

            foreach (var acc in _bankAccounts)
            {
                if (input == acc.CustomerId)
                {
                    if (acc.Saldo != 0)
                    {
                        accountsWithMoney++;
                    }
                }

            }

            if (accountsWithMoney == 0 && customerExist == true)
            {
                foreach (var item in _bankCustomers.ToList())
                {
                    if (item.CustomerId == input)
                    {
                        _bankCustomers.Remove(item);

                        foreach (var acc in _bankAccounts.ToList())
                        {
                            if (acc.CustomerId == input)
                            {
                                _bankAccounts.Remove(acc);
                            }
                        }
                    }
                }

                Console.WriteLine("Customer deleted succesfully");
            }
            else if (customerExist == false)
            {
                Console.WriteLine("CustomerID does not exist");
            }
            else
            {
                Console.WriteLine("Customer is not deleted..\nCustomer have money on account.. ");
            }

            Console.WriteLine("\n\nPress any key too continue");
            Console.ReadLine();
        }
        public static void CreateCustomer()
        {
            //Skapar en ny kund
            Console.Clear();

            Console.WriteLine("Create Customer\n");
            string inputName;
            string inputOrgName;
            string inputAdres;
            string inputAreaCode;
            string inputRegion;
            string inputCity;
            string inputCountry;
            string inputPhoneNumber;

            do
            {
                Console.Write("Name: ");
                inputName = Console.ReadLine();
                if (inputName.Length < 1)
                {
                    Console.WriteLine("Did you fill in name properly\nTry Again");
                }

            } while (inputName.Length < 1);

            do
            {
                Console.Write("Organisationsnummer/personnumber: ");
                inputOrgName = Console.ReadLine();
                if (inputOrgName.Length < 1)
                {
                    Console.WriteLine("Did you fill in Organisationsnummer/personnumber properly");
                }
            } while (inputOrgName.Length < 1);

            do
            {
                Console.Write("Adres: ");
                inputAdres = Console.ReadLine();
                if (inputAdres.Length < 1)
                {
                    Console.WriteLine("Did you fill in Adres properly");
                }
            } while (inputAdres.Length < 1);

            do
            {
                Console.Write("Areacode: ");
                inputAreaCode = Console.ReadLine();
                if (inputAreaCode.Length < 1)
                {
                    Console.WriteLine("Did you fill in Areacode properly");
                }
            } while (inputAreaCode.Length < 1);
            do
            {
                Console.Write("Region: ");
                inputRegion = Console.ReadLine();
                if (inputRegion.Length < 1)
                {
                    Console.WriteLine("Did you fill in Region properly\nTry Again");
                }
            } while (inputRegion.Length < 1);

            do
            {
                Console.Write("City: ");
                inputCity = Console.ReadLine();
                if (inputCity.Length < 1)
                {
                    Console.WriteLine("Did you fill in City properly\nTry Again");
                }
            } while (inputCity.Length < 1);
            do
            {
                Console.Write("Country: ");
                inputCountry = Console.ReadLine();
                if (inputCountry.Length < 1)
                {
                    Console.WriteLine("Did you fill in Country properly\nTry Again");
                }
            } while (inputCountry.Length < 1);
            do
            {
                Console.Write("Phone number: ");
                inputPhoneNumber = Console.ReadLine();
                if (inputPhoneNumber.Length < 1)
                {
                    Console.WriteLine("Did you fill in Phone number properly\nTry Again");
                }

            } while (inputPhoneNumber.Length < 1);

            var newId = CustomerIdMethod();

            Customer cust = new Customer()
            {
                CustomerId = newId,
                Name = inputName,
                OrgNumber = inputOrgName,
                Adress = inputAdres,
                AreaCode = inputAreaCode,
                Region = inputRegion,
                City = inputCity,
                Country = inputCountry,
                Phone = inputPhoneNumber
            };

            _bankCustomers.Add(cust);

            var accountnum = AccountIdMethod();
            Account acc = new Account()
            {
                CustomerId = newId,
                AccountNumber = accountnum,
            };
            _bankAccounts.Add(acc);

            Console.WriteLine("\nCustomer Created. CustomerId:{1}\nNew account created. New Accountnumber: {0}", accountnum, newId);


            Console.WriteLine("\n\n\nPress any key too continue\n");
            Console.ReadLine();
        }

        private static string CustomerIdMethod()
        {
            var lastitem = BankCustomers.Last().CustomerId;
            var newId = int.Parse(lastitem) + 1;
            return newId.ToString();
        }
        private static string AccountIdMethod()
        {
            var lastitem = BankAccounts.Last().AccountNumber;
            var newId = int.Parse(lastitem) + 1;
            return newId.ToString();
        }
    }
}
