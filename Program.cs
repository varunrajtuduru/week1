using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assessment5;

namespace assessment5
{
    class Program
    {
        //Customer customer;
        static void Main(string[] args)
        {
             Program p = new Program();
            p.getCustomerDetail();
            p.displaycustomerdet();
            
            Console.ReadLine();
        }
        public void getCustomerDetail()
        {
            Console.WriteLine("Enter the name,productid,supplierid,numberof products going to buy");
            Customer custom = new Customer();
            custom.customername = Console.ReadLine();
            custom.productid = int.Parse(Console.ReadLine());
            custom.supplierid = int.Parse(Console.ReadLine());
           
            custom.numberofproducts = int.Parse(Console.ReadLine());

            int count = custom.InsertNewCustomer(custom);
            if (count > 0)
                Console.WriteLine("record inserted successfully");
            else
                Console.WriteLine("something went wrong");

        }
        public void displaycustomerdet()
        {
            Customer customer = new Customer();
            customer.displaycustomer(customer);


        }
    }
}
