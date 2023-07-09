using System.Collections.Generic;

namespace SortingAndSendingApi
{
    public class QuickSortInt : ISortingInt
    {
        public void Sort(List<int> numbers)
        {
            QuickSortRecursive(numbers, 0, numbers.Count - 1);
        }

        private static void QuickSortRecursive(List<int> numbers, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(numbers, low, high);

                QuickSortRecursive(numbers, low, pivot - 1);
                QuickSortRecursive(numbers, pivot + 1, high);
            }
        }

        private static int Partition(List<int> numbers, int low, int high)
        {
            int pivot = numbers[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (numbers[j] < pivot)
                {
                    i++;
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            int temp2 = numbers[i + 1];
            numbers[i + 1] = numbers[high];
            numbers[high] = temp2;

            return i + 1;
        }
    }
}
