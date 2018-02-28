namespace Sorting
{
    using System;
    using System.Collections.Generic;

    public static class Utils
    {
        public static void SwapInts(IList<int> list, int index1, int index2)
        {
            int tmp = list[index1];
            list[index1] = list[index2];
            list[index2] = tmp;
        }

        public static bool IsSorted(IList<int> list)
        {
            for (int i = 1; i < list.Count; i ++)
            {
                if (list[i-1] > list[i])
                {
                    return false;
                }
            }

            return true;
        }

        /*** Extensions ***/
        public static void Each<T>(this IEnumerable<T> ie, Action<T, int> action)
        {
            var i = 0;
            foreach (var e in ie) action(e, i++);
        }
    }
}
