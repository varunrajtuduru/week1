using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class customer
    {

        public customer()
        {
            long account5balance = 1234; long account4balance = 1321;
            long account3balance = 123891; long account2balance = 18937;
            long account1balance = 12342;


            Console.WriteLine("Enter the number");
            string[] choice = new string[4] { "0.view_account_balance", "1.deposit_money", "2.withdraw_money", "number>2=>invalid entry" };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(choice[i]);
            }
            int Choosen_number = Convert.ToInt32(Console.ReadLine());
            if (Choosen_number == 0)
            {
                Console.WriteLine("please enter account_id");
                int account_id = Convert.ToInt32(Console.ReadLine());
                if (account_id == 1)
                {
                    Console.WriteLine("your account number is 1234572191");

                    Console.WriteLine("your account balance is\t" + account1balance);
                }
                if (account_id == 2)
                {
                    Console.WriteLine("your account number is 1237827811");

                    Console.WriteLine("your account balance is\t" + account2balance);
                }
                if (account_id == 3)
                {
                    Console.WriteLine("your account number is 7323982391");

                    Console.WriteLine("your account balance is\t" + account3balance);
                }
                if (account_id == 4)
                {
                    Console.WriteLine("your account number is 4898392103");

                    Console.WriteLine("your account balance is\t" + account4balance);
                }
                if (account_id == 5)
                {
                    Console.WriteLine("your account number is 3928932372");

                    Console.WriteLine("your account balance is\t" + account5balance);
                }


            }
            if (Choosen_number == 1)
            {
                Console.WriteLine("please enter account_id");
                int account_id = Convert.ToInt32(Console.ReadLine());

                if (account_id == 1)
                {
                    Console.WriteLine("your account number is 1234572191");
                    Console.WriteLine("please enter how much money you want to deposit");
                    long deposit_money = long.Parse(Console.ReadLine());
                    account1balance = account1balance + deposit_money;
                    Console.WriteLine("your total balance is\t" + account1balance);

                }
                if (account_id == 2)
                {
                    Console.WriteLine("your account number is 1237827811");
                    Console.WriteLine("please enter how much money you want to deposit");
                    long deposit_money = long.Parse(Console.ReadLine());
                    account2balance = account2balance + deposit_money;
                    Console.WriteLine("your total balance is\t" + account2balance);
                }
                if (account_id == 3)
                {

                    Console.WriteLine("your account number is 7323982391");
                    Console.WriteLine("please enter how much money you want to deposit");
                    long deposit_money = long.Parse(Console.ReadLine());
                    account3balance = account3balance + deposit_money;
                    Console.WriteLine("your total balance is\t" + account3balance);
                }
                if (account_id == 4)
                {
                    Console.WriteLine("your account number is 4898392103");
                    Console.WriteLine("please enter how much money you want to deposit");
                    long deposit_money = long.Parse(Console.ReadLine());
                    account4balance = account4balance + deposit_money;
                    Console.WriteLine("your total balance is\t" + account4balance);
                }
                if (account_id == 5)
                {
                    Console.WriteLine("your account number is 3928932372");
                    Console.WriteLine("please enter how much money you want to deposit");
                    long deposit_money = long.Parse(Console.ReadLine());
                    account5balance = account5balance + deposit_money;
                    Console.WriteLine("your total balance is\t" + account5balance);

                    
                }
            }

                if (Choosen_number == 2)
                {
                    Console.WriteLine("please enter account_id");
                    int account_id = Convert.ToInt32(Console.ReadLine());

                    if (account_id == 1)
                    {
                        Console.WriteLine("your account number is 1234572191");
                        Console.WriteLine("please enter how much money you want to withdraw");
                        long withdraw_money = long.Parse(Console.ReadLine());
                        if (withdraw_money > account1balance) Console.WriteLine("insuffient balance");
                        else account1balance = account1balance - withdraw_money;
                        Console.WriteLine("your total balance is\t" + account1balance);
                    }
                    if (account_id == 2)
                    {
                        Console.WriteLine("your account number is 1237827811");
                        Console.WriteLine("please enter how much money you want to withdraw");
                        long withdraw_money = long.Parse(Console.ReadLine());
                        if (withdraw_money > account1balance) Console.WriteLine("insuffient balance");
                        else account2balance = account2balance - withdraw_money;
                        Console.WriteLine("your total balance is\t" + account2balance);
                    }
                    if (account_id == 3)
                    {

                        Console.WriteLine("your account number is 7323982391");
                        Console.WriteLine("please enter how much money you want to withdraw");
                        long withdraw_money = long.Parse(Console.ReadLine());
                        if (withdraw_money > account1balance) Console.WriteLine("insuffient balance");
                        else account3balance = account3balance - withdraw_money;
                        Console.WriteLine("your total balance is\t" + account3balance);
                    }
                    if (account_id == 4)
                    {
                        Console.WriteLine("your account number is 4898392103");
                        Console.WriteLine("please enter how much money you want to withdraw");
                        long withdraw_money = long.Parse(Console.ReadLine());
                        if (withdraw_money > account1balance) Console.WriteLine("insuffient balance");
                        else account4balance = account4balance - withdraw_money;
                        Console.WriteLine("your total balance is\t" + account4balance);
                    }
                    if (account_id == 5)
                    {
                        Console.WriteLine("your account number is 3928932372");
                        Console.WriteLine("please enter how much money you want to withdraw");
                        long withdraw_money = long.Parse(Console.ReadLine());
                        if (withdraw_money > account1balance) Console.WriteLine("insuffient balance");
                        else account5balance = account5balance - withdraw_money;
                        Console.WriteLine("your total balance is\t" + account5balance);
                    }









                }

            Console.ReadLine();

        }
        }
    }

