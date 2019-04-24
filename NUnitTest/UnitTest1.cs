using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Console_test_Sort.Class;
using Console_test_Sort.Interfaces;
using Console_test_Sort.SortingTypes;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //    Thread.Sleep(1000);
        //}

        //[Test]
        public void TestTime()
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
            //throw  new Exception();
            Thread.Sleep(1000);
            //Assert.Pass();

            
        }



        [Test]
        public void TestSort()
        {
            Random rnd = new Random();
            var syze = 1000;
            var typesOfSort = new List<Context>();
            //add our types of sort
            typesOfSort.Add(new Context(new BubbleSort()));
            typesOfSort.Add(new Context(new SelectionSort()));
            typesOfSort.Add(new Context(new InsertionSort()));

            foreach (var i4 in typesOfSort)
            {
                int[] ar = new int[syze];
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = rnd.Next(-100, 100);
                }
                Thread.Sleep(100);
                i4.DoSomeSort(ar);

                // Ckeck syze of array
                if (ar.Length != syze) throw new Exception();

                //Check if do not sort
                for (var i = 0; i < ar.Length - 1; i++)
                {
                    if (ar[i] > ar[i + 1]) throw new Exception();
                }
                Thread.Sleep(100);
            }

            Thread.Sleep(100);
        }
    }
}