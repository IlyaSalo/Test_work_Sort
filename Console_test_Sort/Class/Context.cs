using Console_test_Sort.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console_test_Sort.Class
{
    public class Context
    {
        private ISort _sortMeth;

        public Context() { }
        public Context(ISort sortType)
        {
            _sortMeth = sortType;
        }
        public void SetSortMeth(ISort sortType)
        {
            _sortMeth = sortType;
        }

        public int[] DoSomeSort(int[] data)
        {
            _sortMeth.Sort(data);
            return data;
        }
    }
}
