using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //declaring array and variable
        private int[] Azhar = new int[30];
        int n;
        int i;

        //creating a method for receiving input
        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 30))
                    break;
                else
                    Console.WriteLine("\nArray should have a minimum of 1 and a maximum of 30 elements.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("=====================");
            Console.WriteLine(" Enter array elements");
            Console.WriteLine("=====================");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                Azhar[i] = Int32.Parse(s1);
            }
        }
        //creating a method to sort array using insertion sort
        public void insertionsort()
        {
            for (int i = 0; i < n; i++)
            {
                int temp = Azhar[i];
                int TA = i - 1;
                while (TA >= 0 && Azhar[TA] > temp)
                {
                    Azhar[TA + 1] = Azhar[TA];
                    TA = TA - 1;
                }
                Azhar[TA + 1] = temp;
            }
        }

        //creating a method to display the sorted array
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Sorted array elements ");
            Console.WriteLine("------------------------");
            for (int TA = 0; TA < n; TA++)
            {
                Console.WriteLine(Azhar[TA]);
            }
            Console.WriteLine("");
        }

        //creating a method to merge array
        static public void MainMerge(int[] Azhar, int low, int mid, int high)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = low;
            num = (high - low + 1);

            while ((low <= eol) && (mid <= high))
            {
                if (Azhar[low] <= Azhar[mid])
                    temp[pos++] = Azhar[low++];
                else
                    temp[pos++] = Azhar[mid++];
            }
            while (low <= eol)
                temp[pos++] = Azhar[low++];
            while (mid <= high)
                temp[pos++] = Azhar[mid++];
            for (i = 0; i < num; i++)
            {
                Azhar[high] = temp[high];
                high--;
            }
        }
    }
}