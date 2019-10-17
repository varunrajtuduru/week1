using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class products
    {
        
        public products()
            {
            string[] products = new string[5] { "0.TV", "1.MOBILE", "2.AC", "3.WASHING_MACHINE", "4.DISH_WASHER" };
            int[] cost = new int[5] { 12000, 13000, 14000, 15000, 16000 };
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(products[i]);
            }
            Console.WriteLine("Choose number of products you wish to buy");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int[] product_number = new int[numbers];
            Console.WriteLine("Choose the product_number you like to buy");
            for(int i=0;i<numbers;i++)
            {
                product_number[i] = Convert.ToInt32(Console.ReadLine());
                if (product_number[i] > 4) Console.WriteLine("invalid entry");
            }
            
            for(int i=0;i<numbers;i++)
            {
                
                if (product_number[i] == 0)Console.WriteLine("you have choosen tv and price is 12000");
                if (product_number[i] == 1) Console.WriteLine("you have choosen mobile and price is 13000");
                if (product_number[i] == 2) Console.WriteLine("you have choosen ac and price is 14000");
                if (product_number[i] == 3) Console.WriteLine("you have choosen washing_machine and price is 15000");
                if (product_number[i] == 4) Console.WriteLine("you have choosen dish_washer and price is 16000");
            }
            Console.WriteLine("your total bill is");
            int bill = 0;
            for(int i=0;i<numbers;i++)
            {
                
                bill = bill + cost[product_number[i]];
            }
            Console.WriteLine(bill);
            Console.ReadLine();


        }

    }
}
