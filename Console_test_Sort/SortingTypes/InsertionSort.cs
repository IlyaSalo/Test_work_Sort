using System;
using System.Collections.Generic;
using System.Text;
using Console_test_Sort.Interfaces;

namespace Console_test_Sort.SortingTypes
{
    public class InsertionSort : ISort
    {
        private void Exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public void Sort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    Exchange(data, i, i - 1);
                }
            }
        }

    }
}

