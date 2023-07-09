using System.Collections.Generic;

namespace SortingAndSendingApi.Sortings
{
    public interface ISorting <T>
    {
        void Sort(List<T> item);
    }
}
