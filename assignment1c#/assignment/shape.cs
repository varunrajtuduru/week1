using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    
    class shape
    {
        int length;
        int breadth;
        int tbase;
        int height;
        int radius;
        public shape()
        {
            Console.WriteLine("Choose the shape");
            Console.WriteLine("1.triangle\n 2.rectangle\n 3.circle\n 4.square");
           
            Console.WriteLine("Enter the number");
            int k = Convert.ToInt32(Console.ReadLine());
            if(k==1)
            {
                Console.WriteLine("you have choosen triangle");
                Console.WriteLine("Enter the base value");
                tbase = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the height value");
                height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("area of the triangle is");
                Console.WriteLine(0.5*tbase * height);
                

            }
            if (k == 2)
            {
                Console.WriteLine("you have choosen rectangle");
                Console.WriteLine("Enter the length value");
                length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the breadth value");
                breadth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("area of the rectangle is");
                Console.WriteLine(length * breadth);


            }
            if (k == 3)
            {
                Console.WriteLine("you have choosen circle");
                Console.WriteLine("Enter the radius value");
                radius = Convert.ToInt32(Console.ReadLine());
              
                Console.WriteLine("area of the circle is");
                Console.WriteLine((3.142)*radius*radius);


            }
            if (k == 4)
            {
                Console.WriteLine("you have choosen square");
                Console.WriteLine("Enter the length of side value");
                length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("area of the square is");
                Console.WriteLine(length * length);


            }

            Console.ReadLine();




            
        }

    }
}
