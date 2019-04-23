using System;
using System.Collections.Generic;
using System.Text;
using Console_test_Sort.Interfaces;

namespace Console_test_Sort.SortingTypes
{
    public class BubbleSort : ISort
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

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        Exchange(data, i, i + 1);
                }
            }
        }

    }
}

