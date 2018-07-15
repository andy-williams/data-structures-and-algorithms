using System.Collections.Generic;

namespace Algorithms
{
    public static class Sort
    {
        public static IList<T> QuickSort<T>(this IList<T> @this, IComparer<T> comparer = null)
        {
            if (comparer == null)
                comparer = Comparer<T>.Default;

            if (@this == null)
                return null;

            if (@this.Count == 1)
                return @this;
            
            // partition
            var newList = new T[@this.Count];
            @this.CopyTo(newList, 0);
            newList.QuickSort(0, @this.Count - 1, comparer);

            return newList;
        }

        private static int Partition<T>(this IList<T> @this, int start, int end, IComparer<T> comparer)
        {
            var pivotIndex = start;
            var pivot = @this[pivotIndex];

            var i = start - 1;
            for (var j = start; j < end - 1; j++)
            {
                var a = @this[j];

                if (comparer.Compare(a, pivot) < 0)
                {
                    // swap
                    i++;
                    var b = @this[i];
                    @this[i] = a;
                    @this[j] = b;
                }

                //var tmp = @this[i + 1];
                //@this[i + 1] = @this[end];
                //@this[end] = tmp;
            }

            return i + 1;
        }

        private static void QuickSort<T>(this IList<T> @this, int start, int end, IComparer<T> comparer)
        {
            if (start >= end)
                return;

            var partitionIndex = @this.Partition(start, end, comparer);
            @this.QuickSort(start, partitionIndex - 1, comparer);
            @this.QuickSort(partitionIndex + 1, end, comparer);
        }

        public static IList<T> MergeSort<T>(this IList<T> @this)
        {
            return @this;
        }
    }
}
