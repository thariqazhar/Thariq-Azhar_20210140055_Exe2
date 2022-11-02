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
            int[] temp = new int[30];
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

        //creating a method to sort the merged array
        static public void SortMerge(int[] Azhar, int low, int high)
        {
            int mid;
            if (high > low)
            {
                mid = (high + low) / 2;
                SortMerge(Azhar, low, mid);
                SortMerge(Azhar, (mid + 1), high);
                MainMerge(Azhar, low, (mid + 1), high);
            }
        }

        //creating main so that the program can run
        static void Main(string[] args)
        {
            //declaring pilihanmenu
            Program P = new Program();
            int pilihanmenu;

            //creating a menu
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("==================");
                Console.WriteLine("1.insertion sort");
                Console.WriteLine("2.merge sort");
                Console.WriteLine("3.Exit");
                Console.Write("Enter your choice (1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine(". . . . . . . . . . . .");
                        Console.WriteLine("insertion sort");
                        Console.WriteLine(". . . . . . . . . . . .");
                        P.input();
                        P.insertionsort();
                        P.display();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine(". . . . . . . . . . . .");
                        Console.WriteLine("merge sort");
                        Console.WriteLine(". . . . . . . . . . . .");
                        Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
                        Console.Write("\n\nEnter number of elements: ");
                        int max = Convert.ToInt32(Console.ReadLine());
                        int[] numbers = new int[max];
                        for (int i = 0; i < max; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max; k++)
                        {
                            Console.Write(numbers[k] + " ");
                            Console.Write("\n");
                        }
                        Console.WriteLine("Sorted Array");
                        SortMerge(numbers, 0, max - 1);
                        for (int i = 0; i < max; i++)
                            Console.WriteLine(numbers[i]);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("exit");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                Console.WriteLine("\n\nPress Return to exit");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}