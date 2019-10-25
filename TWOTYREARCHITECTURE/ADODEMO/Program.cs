using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMPLOYEE_DATAAXISLAYER_;

namespace ADODEMO
{
    class Program
    {
        Employee employee;
        static void Main(string[] args)
        {
            Program p = new Program();
            // p.getEmployeeDetail();
            //p.delemployee();
            //p.updateEmployeeDet();
            p.displayemployeebyid();
            Console.ReadLine();
        }

        public void getEmployeeDetail()
        {
            Console.WriteLine("Enter the name,gender,Location,salary");
            employee = new Employee();
            employee.name = Console.ReadLine();
            employee.gender = Console.ReadLine();
            employee.location = Console.ReadLine();
            employee.salary = int.Parse(Console.ReadLine());
            
            int count = employee.InsertNewEmployee(employee);
            if (count > 0)
                Console.WriteLine("record inserted successfully");
            else
                Console.WriteLine("something went wrong");

        }
        public void delemployee()
        {
            Employee employee = new Employee();
            employee.id = int.Parse(Console.ReadLine());
            
            int count=employee.deleteemployee(employee);
            if (count > 0)
                Console.WriteLine("record  deleted successfully");
            else
                Console.WriteLine("something went wrong");
            

        }
        public void updateEmployeeDet()
        {
            Console.WriteLine("enter employee id of which u want to update");
            Employee employee = new Employee();
            employee.id = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter the name,gender,Location,salary");
            
            employee.name = Console.ReadLine();
            employee.gender = Console.ReadLine();
            employee.location = Console.ReadLine();
            employee.salary = int.Parse(Console.ReadLine());
            Employee emp = new Employee();
            int count = emp.updateEmployee(employee);
            if (count > 0)
                Console.WriteLine("record updated successfully");
            else
                Console.WriteLine("something went wrong");

        }

        public void displayemployeedet()
        {
            Employee employee = new Employee();
            employee.displayemployee(employee);


        }
        public void displayemployeebyid()
        {
            Employee employee = new Employee();
            employee.id = int.Parse(Console.ReadLine());
            employee.displayemploy(employee);


        }

    }
}
