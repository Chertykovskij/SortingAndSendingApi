using System;
using System.Collections.Generic;

namespace SortingAndSendingApi
{
    public class BubbleSortInt : ISortingInt
    {
        public void Sort(List<int> numbers)
        {
            int n = numbers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
    }
}
