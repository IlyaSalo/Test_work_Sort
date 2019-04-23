using System;
using System.Collections.Generic;
using System.Text;
using Console_test_Sort.SortingTypes;

namespace Console_test_Sort.Class
{
    public class StartProject
    {
        public void Start()
        {
            Console.WriteLine("Generating an array. Please indicate the size of the array:");
            Random rnd = new Random();

            var syze = 100;
            var selectSyze = Console.ReadLine();
            if (int.TryParse(selectSyze, out int number))
            {
                syze = number;
            }
            int[] ar = new int[syze];

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Array was generated. Length is - {0};", ar.Length);
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Select a sorting method:");
            Console.WriteLine("SelectionSort - click 1;");
            Console.WriteLine("InsertionSort - click 2;");
            Console.WriteLine("BubbleSort - click 3;");
            var selectSrting = Console.ReadLine();
            var sorter = new Context(new BubbleSort());
            var result = new int[syze];
            switch (selectSrting)
            {
                case "1":
                    Console.WriteLine("SelectionSort :");
                    sorter.SetSortMeth(new SelectionSort());
                    sorter.DoSomeSort(ar);
                    break;
                case "2":
                    Console.WriteLine("InsertionSort :");
                    sorter.SetSortMeth(new InsertionSort());
                    sorter.DoSomeSort(ar);
                    break;
                case "3":
                    Console.WriteLine("BubbleSort :");
                    sorter.DoSomeSort(ar);
                    break;
                default:
                    Console.WriteLine(" Ok! It will be BubbleSort))");
                    sorter.DoSomeSort(ar);
                    break;
            }
            
            Console.WriteLine();
            Console.WriteLine("Array after sort: \t");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
