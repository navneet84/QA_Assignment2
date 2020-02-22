using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool check = true;
            do
            {
                Console.WriteLine("1.Enter Triangle Dimensions");

                Console.WriteLine("2.Exit");

                int a = int.Parse(Console.ReadLine());

                check = true;
                switch (a)
                {
                    case 1:

                        Console.WriteLine("\n\nEnter All sides of Triangle\n");
                        int x = 0; int y = 0; int z = 0;

                        try
                        {
                            Console.Write("Enter Value of Side 1 for Triangle: ");
                            x = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Value of Side 2 for Triangle: ");
                            y = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Value of Side 3 for Triangle: ");
                            z = Convert.ToInt32(Console.ReadLine());
                        }catch(Exception e)
                        {
                            Console.WriteLine("\n\nEnter valid input");
                            continue;
                        }
                       

                        if((((x+y)>z) && ((y+z) > x) && ((x+z) > y)) == false)
                        {
                            Console.WriteLine("\nThe given sides doesn't form the triangle");
                            continue;
                        }
 
                        if((x<=0) || (y<=0) || (z<=0))
                        {
                            Console.WriteLine("Not a valid side input");
                            continue;
                        }

                        Console.WriteLine(TriangleSolver.Analyse(x, y, z));

                        break;

                    case 2:
                        Console.WriteLine("Exiting...");
                        check = false;
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong input! Enter 1 or 2 only \n ");
                        break;
                }
            } while (check);


        }        
    }
}
