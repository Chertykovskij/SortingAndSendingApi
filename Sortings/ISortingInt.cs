using SortingAndSendingApi.Sortings;
using System.Collections.Generic;

namespace SortingAndSendingApi
{
    public interface ISortingInt : ISorting<int>
    {
        new void Sort(List<int> numbers);
    }
}
