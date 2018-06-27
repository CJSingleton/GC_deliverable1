using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Num1, Num2;
            bool end;
            int[] array1, array2, array3;

            Console.WriteLine("Hello! In this program you will be entering two integer values (whole numbers) of your choosing.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("There are four rules:");
            Console.WriteLine("1) Both numbers must be positive");
            Console.WriteLine("2) Both numbers must be no more than 9 digits long");
            Console.WriteLine("3) Both numbers must have the same number of digits");
            Console.WriteLine("4) Do not use any leading zeroes (i.e., no 023, 0045, or 0030)");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("If all of the digits for each number added together have the same total," +
                " your result will be 'True.' If not, your result will be 'False.'");
            Console.WriteLine("Please enter your first number below: ");
            
            Num1 = Console.ReadLine(); //first user input
            
            if (Convert.ToInt32(Num1) <= 0)//first user input check
            {
                Console.WriteLine("Remember, both integers must be positive numbers.");
                Console.WriteLine("Hit enter to close the console and try again.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Great! Now, enter your second number below: ");
            }

            Num2 = Console.ReadLine();//second user input

            if (Convert.ToInt32(Num2) <= 0)//second user input check
            {
                Console.WriteLine("Remember, both integers must be positive numbers.");
                Console.WriteLine("Hit enter to close the console and try again.");
                Console.ReadLine();
            }

            if (Num1.Length != Num2.Length)//final user input check
            {
                Console.WriteLine("Remember, both integers must have the same number of digits!");
                Console.WriteLine("Hit enter to close the console and try again.");
                Console.ReadLine();
            }
            else
            {
                array1 = MakeArray(Convert.ToInt32(Num1));
                array2 = MakeArray(Convert.ToInt32(Num2));
                
                array3 = AddArrays(array1, array2);

                end = Compare(array3);

                Console.WriteLine("Your result:");
                Console.WriteLine(end);
                Console.WriteLine("Press any key to close console.");
                Console.ReadKey();
            }
        }
        
        public static int[] MakeArray(int num)//Converts user input to array
        {
            string s, number = num.ToString();
            char[] chararray = number.ToCharArray();// char array
            int L = number.Length;
            int[] array1 = new int[L];// int array
            for (int i = 0; i < L; i++)
            {
                s = number[i].ToString();
                array1[i] = Convert.ToInt32(s);
            }
            return array1;
        }

        public static int[] AddArrays(int[] a, int[] b)//Adds the elements of each array
        {
            int[] newArray = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                newArray[i] = a[i] + b[i];
            }
            return newArray;
        }

        public static bool Compare(int[] a)//Checks to see if each value in combined array are the same
        {
            for (int x = 0; x < (a.Length - 1); x++)
            {
                    {
                    if (a[x] != a[x + 1])
                    return false;
                    }
            }
            return true;
        }
    }
}