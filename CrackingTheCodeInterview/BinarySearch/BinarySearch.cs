using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {

        }

        public static int Search(int[] array, int element)
        {
            int min = 0;
            int max = array.Length - 1;
            if (array == null || array.Length == 0)
                return -1;
            
            while(max >= min)
            {
                int mid = (min + max) / 2;
                if (array[mid] == element)
                    return mid;
                else if (element > mid)
                    min = mid + 1;
                else if (element < mid)
                    max = mid - 1;
                else return -1;
            }
            return -1;
        }

    }
}
