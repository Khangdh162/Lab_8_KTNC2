using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class ArrayOperations
    {
        public int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Mảng không thể rỗng hoặc trống");

            int max = array[0];
            foreach (var num in array)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        // Phương thức tìm giá trị nhỏ nhất trong mảng
        public int FindMin(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Mảng không thể rỗng hoặc trống");

            int min = array[0];
            foreach (var num in array)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
    }

}
