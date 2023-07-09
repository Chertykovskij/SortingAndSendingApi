using System;
using System.Collections.Generic;

namespace SortingAndSendingApi
{
    public class CreatorRandomSorting
    {
        public static ISortingInt CreatSorting()
        {
            var random = new Random();

            // Выбор случайного алгоритма сортировки
            var sortingAlgorithms = new List<ISortingInt> { new BubbleSortInt(), new QuickSortInt() };
            var selectedAlgorithm = sortingAlgorithms[random.Next(sortingAlgorithms.Count)];

            return selectedAlgorithm;
        }
    }
}
