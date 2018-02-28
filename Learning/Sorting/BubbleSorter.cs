namespace Sorting
{
    using System;
    using System.Collections.Generic;

    public class BubbleSorter : ISorter
    {
        public void Sort(IList<int> list)
        {
            int n = list.Count;

            for (int i = 0; i < n - 1; i ++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j ++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Utils.SwapInts(list, j, j + 1);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }
    }
}
