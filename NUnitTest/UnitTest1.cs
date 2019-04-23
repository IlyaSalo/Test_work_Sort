using System;
using System.Linq;
using System.Threading;
using Console_test_Sort.Class;
using Console_test_Sort.SortingTypes;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            Random rnd = new Random();
            var sorter = new Context(new BubbleSort());
            var syze = 10000;
            int[] ar = new int[syze];
            
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-100, 100);
            }
            
            var arrForBubbleSort = ar.ToArray();
            var arrForSelectionSort = ar.ToArray();
            var arrForInsertionSort = ar.ToArray();

            var watchBubbleSort = System.Diagnostics.Stopwatch.StartNew();
            sorter.DoSomeSort(arrForBubbleSort);
            watchBubbleSort.Stop();

            sorter.SetSortMeth(new SelectionSort());
            var watchSelectionSort = System.Diagnostics.Stopwatch.StartNew();
            sorter.DoSomeSort(arrForSelectionSort);
            watchSelectionSort.Stop();

            sorter.SetSortMeth(new InsertionSort());
            var watchInsertionSort = System.Diagnostics.Stopwatch.StartNew();
            sorter.DoSomeSort(arrForInsertionSort);
            watchInsertionSort.Stop();

            var bubbleSortTime = watchBubbleSort.ElapsedMilliseconds;
            var selectionSortTime = watchSelectionSort.ElapsedMilliseconds;
            var insertionSortTime = watchInsertionSort.ElapsedMilliseconds;

            Thread.Sleep(1000);
            //Assert.Pass();
        }
    }
}