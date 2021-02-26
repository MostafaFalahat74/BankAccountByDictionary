using BankAccount.Controller;
using System;

namespace BankAccount
{
    class Program
    {

        static void Main(string[] args)
        {

            string userName;
            bool permissionToBuildAccount;
            Operations operations = new Operations();
            string userChoice;
            int accountDeposit;
            int nationalCard;
            int inventory;
            int amountMoneyDeposit;
            int age;

            while (true)
            {

                Console.WriteLine("1 : For Create Account  ");
                Console.WriteLine("2 : For Deposit To Account  ");
                Console.WriteLine("3 : For Show Inventory  ");
                Console.WriteLine("4 : For Delete Account  ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":

                        Console.WriteLine("Plese Enter User Name");
                        userName = Console.ReadLine();

                        Console.WriteLine("Plese Enter National Card");
                        nationalCard = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Plese Enter Age");
                        age = Int32.Parse(Console.ReadLine());

                        permissionToBuildAccount = operations.CheckUserAge(age);
                        if (permissionToBuildAccount)
                        {
                            Console.WriteLine("Plese Enter Inventory");
                            inventory = Int32.Parse(Console.ReadLine());
                             operations.CreateNewUser( nationalCard, inventory);
                            Console.Clear();
                            Console.WriteLine($"Account Number : {nationalCard} And inventory : {inventory} ");
                        }
                        else
                        {
                            Console.WriteLine("  your age has under 18 ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(" please enter father name ");
                            string fatherName = Console.ReadLine();


                            Console.WriteLine(" please enter father age ");
                            int fatherAge = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Plese Enter Inventory");
                            inventory = Int32.Parse(Console.ReadLine());
                            Console.Clear();
                            if (fatherAge > 18)
                            {
                                 operations.CreateNewUser( nationalCard, inventory);
                                Console.WriteLine($"Account Number : {nationalCard} And inventory : {inventory} ");
                            }
                            else
                            {
                                Console.WriteLine(" sorry father age under 18");
                            }
                        }


                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Plese Enter Account to Deposit money");
                        int accountNumber = Int32.Parse(Console.ReadLine());
                        int accountIndex = operations.CheckAccountExist(accountNumber);
                        if (accountIndex != 0)
                        {
                            Console.WriteLine("Plese Enter User amount of money to deposit");
                            amountMoneyDeposit = Int32.Parse(Console.ReadLine());
                            operations.DepositMoneyToAccount(accountIndex, amountMoneyDeposit);
                            Console.Clear();
                            Console.WriteLine($"the amount of {amountMoneyDeposit} to the account {accountIndex} deposited");
                          
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The Account Does Not Exist ");
                        }
                      

                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Plese Enter Account Number");
                        accountDeposit = Int32.Parse(Console.ReadLine());
                        int accountExist = operations.CheckAccountExist(accountDeposit);

                        if (accountExist != 0)
                        {
                            Console.Clear();
                            var inventoryAccount = operations.ShowInventory(accountExist);
                            Console.WriteLine($" inventor of account {accountDeposit} is {inventoryAccount}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("the account is dont exist");
                        }


                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Plese Enter Account to Deposit money");
                        int account = Int32.Parse(Console.ReadLine());
                        int accountForDeleteExist = operations.CheckAccountExist(account);
                        if (accountForDeleteExist != 0)
                        {
                            operations.DeleteAccount(accountForDeleteExist);

                            Console.Clear();
                            Console.WriteLine($"Account {account} deleted");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" Account Does Not Exist ");
                        }

                        break;
                }

            }

        }

    }
}
