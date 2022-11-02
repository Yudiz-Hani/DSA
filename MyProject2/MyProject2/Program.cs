using System;
using System.Linq;

namespace MyProject2
{
    class Program
    {
       // static void Main(string[] args)
        //{


            //WAYS TO DECLARING ARRAY

            //int[] num = { 10, 2, 3, 14, 0 };
            //string[] car = new string[4];
            //int[] no = new int[4] { 1, 2, 3, 4 };
            //string[] car1 = new string[] { "BMW", "Audi", "Ford" };

            // int[,] arr2d; // two-dimensional array
            // int[,,] arr3d; // three-dimensional array
            // int[,,,] arr4d; // four-dimensional array
            // int[,,,,] arr5d; // five-dimensional array

            //int[,] arr2d = new int[3,2]{ 
            //                 { 1, 2}, 
            //                 { 3, 4}, 
            //                 { 5, 6}
            //               };

            //RETRIVING DATA

            //Console.WriteLine(num[0]);
            //Console.WriteLine(num[1]);
            //Console.WriteLine(num[2]);

            //arr2d[0, 0]; //returns 1
            //arr2d[0, 1]; //returns 2

            //  LOOP THROUGH ARRAY

            //foreach(var n in car1)
            //{
            //    Console.WriteLine(n);
            //}

            //for(int i=0;i<car1.Length;i++)
            //{
            //    Console.WriteLine(car1[i]);
            //}

            //int i = 0;
            //while (i < car1.Length)
            //{
            //    Console.WriteLine(car1[i]);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(car1[i]);
            //    i++;
            //}
            //while (i < car1.Length);

            //A jagged array is an array of arrays, and therefore its elements are reference
            //types and are initialized to null.

            //METHODS
            //int total = num.Sum();
            //Console.WriteLine(total);

            //int total_element = num.Count();
            //Console.WriteLine(total_element);

            //int min_value = num.Min();
            //Console.WriteLine(min_value);

            //int max_value = num.Max();
            //Console.WriteLine(max_value);

            //Array.Sort(num);

            //Array.Reverse(num);



            //-----------------------------------------------------------------------

            //EXCEPTION HANDLING

            //int no = 2;
            ////int no = 15;
            //int i = 0;

            //if(no==2)
            //{
            //    throw new Exception("The Number is Two");
            //}
            //try
            //{
            //    int ans = no / i;
            //}
            
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            
            //finally
            //{
            //    Console.WriteLine("This is finally block");
            //}



         //   Console.ReadKey();
        //}
    }
}
