using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Employee
    {
        private int id, salary;
        private string name, designation, location;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Location { get => location; set => location = value; }
    }

    


    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employeelist = new List<Employee>();
            employeelist.Add(new Employee { Id = 1, Name = "raj", Salary = 12000, Designation = "admin", Location = "bangalore" });
            employeelist.Add(new Employee { Id = 2, Name = "ram", Salary = 13000, Designation = "customer support", Location = "bangalore" });
            employeelist.Add(new Employee { Id = 4, Name = "rajesh", Salary = 14000, Designation = "freelancer", Location = "bangalore" });
            employeelist.Add(new Employee { Id = 3, Name = "ramesh", Salary = 15000, Designation = "ux developer", Location = "bangalore" });
            foreach (var item in employeelist)
            {
                Console.WriteLine(item.Name + "\t" + item.Id + "\t" + item.Location + "\t" + item.Salary + "\t"+item.Designation);
            }
           
            void create()
            {
                employeelist.Add(new Employee { Id = Convert.ToInt32(Console.ReadLine()), Name = Console.ReadLine(), Salary = Convert.ToInt32(Console.ReadLine()), Designation = Console.ReadLine(), Location = Console.ReadLine() });
            }
          
            int call = Convert.ToInt32(Console.ReadLine());
            if (call == 1)
            {
                create();
                foreach (var item in employeelist)
                {
                    Console.WriteLine(item.Name + "\t" + item.Id + "\t" + item.Location + "\t" + item.Salary + "\t" + item.Designation);
                }


            }
            try
            {
                if (call == 2)
                {
                    int l = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in employeelist)
                    {
                        if (item.Id == l)
                            employeelist.Remove(item);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
                foreach (var item in employeelist)
                {
                    Console.WriteLine(item.Name + "\t" + item.Id + "\t" + item.Location + "\t" + item.Salary + "\t" + item.Designation);
                }
            if (call == 3)
            {
                Console.WriteLine("Enter the element(by id) you want to edit");
                int b = Convert.ToInt32(Console.ReadLine());
                try
                {
                    foreach (Employee item1 in employeelist)
                    {
                        if (item1.Id == b)
                        {
                            employeelist.Remove(item1);
                            //    Console.WriteLine("Enter the field you wanted to edit \n 2-name\n 3-designation\n 4-location\n 5-salary");
                            //    int k = Convert.ToInt32(Console.ReadLine());
                            //    if (k == 2)
                            //    {

                            //        data.Insert(b - 1, new employee { Id = 2, Name = Console.ReadLine(), Designation = "Student", Location = "DElhi", Salary = 20000 });
                            //    }
                            //    else if(k==3)
                            //    {
                            //        data.Insert(b - 1, new employee { Id = 2, Name = Console.ReadLine(), Designation = "Student", Location = "DElhi", Salary = 20000 });
                            //    }

                            //    foreach (employee emp in data)
                            //    {
                            //        Console.WriteLine("\n ID:" + emp.Id);
                            //        Console.WriteLine("\n Name:" + emp.Name);
                            //        Console.WriteLine("\n Designation:" + emp.Designation);
                            //        Console.WriteLine("\n Location:" + emp.Location);
                            //        Console.WriteLine("\n Salary:" + emp.Salary);
                            //    }
                            //}
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                Console.WriteLine("Enter the updated id,name,location,designation,salary one by one");
                employeelist.Add(new Employee { Id = Convert.ToInt32(Console.ReadLine()), Name = Console.ReadLine(), Designation = Console.ReadLine(), Location = Console.ReadLine(), Salary = Convert.ToInt32(Console.ReadLine()) });
                foreach (Employee emp in employeelist)
                {
                    Console.WriteLine("\n ID:" + emp.Id);
                    Console.WriteLine("\n Name:" + emp.Name);
                    Console.WriteLine("\n Designation:" + emp.Designation);
                    Console.WriteLine("\n Location:" + emp.Location);
                    Console.WriteLine("\n Salary:" + emp.Salary);
                }



                foreach (var item in employeelist)
                {
                    Console.WriteLine(item.Name + "\t" + item.Id + "\t" + item.Location + "\t" + item.Salary + "\t" + item.Designation);
                }

            }


            Console.ReadLine();
        }
        
    }
}
