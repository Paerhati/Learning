namespace SortingTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Sorting;

    [TestClass]
    public class SortingTests
    {
        private List<int> GenerateRandomList(int length)
        {
            Random rnd = new Random();
            List<int> result = new List<int>();

            for (int i = 0; i < length; i++)
                result.Add(rnd.Next());

            return result;
        }

        [TestMethod]
        public void SortBubbleSort()
        {
            BubbleSorter bs = new BubbleSorter();
            TestSorterInterface(bs);
        }

        [TestMethod]
        public void TestSorterInterface(ISorter sorter)
        {
            List<int> unsortedList = new List<int>()
            {
                1, 2, 3, 4, 3, 5, 6, 7
            };

            Assert.IsFalse(Utils.IsSorted(unsortedList));
            sorter.Sort(unsortedList);
            Assert.IsTrue(Utils.IsSorted(unsortedList));

            List<int> emptyList = new List<int>()
            {
            };

            Assert.IsTrue(Utils.IsSorted(emptyList));
            sorter.Sort(emptyList);
            Assert.IsTrue(Utils.IsSorted(emptyList));

            List<int> singleList = new List<int>()
            {
                0
            };

            Assert.IsTrue(Utils.IsSorted(singleList));
            sorter.Sort(singleList);
            Assert.IsTrue(Utils.IsSorted(singleList));

            List<int> negativeSortedList = new List<int>()
            {
                -5, -4, -3, -1, 0, 1, 5, 6, 8
            };

            Assert.IsTrue(Utils.IsSorted(negativeSortedList));
            sorter.Sort(negativeSortedList);
            Assert.IsTrue(Utils.IsSorted(negativeSortedList));

            List<int> sortedListWithDuplicates = new List<int>()
            {
                -5, -5, 0, 2, 4, 5, 5, 6, 7
            };

            Assert.IsTrue(Utils.IsSorted(sortedListWithDuplicates));
            sorter.Sort(sortedListWithDuplicates);
            Assert.IsTrue(Utils.IsSorted(sortedListWithDuplicates));
        }

        [TestMethod]
        public void SortingTest()
        {
            List<int> unsortedList = new List<int>()
            {
                1, 2, 3, 4, 3, 5, 6, 7
            };

            Assert.IsFalse(Utils.IsSorted(unsortedList));

            List<int> emptyList = new List<int>()
            {
            };

            Assert.IsTrue(Utils.IsSorted(emptyList));

            List<int> singleList = new List<int>()
            {
                0
            };

            Assert.IsTrue(Utils.IsSorted(singleList));

            List<int> negativeSortedList = new List<int>()
            {
                -5, -4, -3, -1, 0, 1, 5, 6, 8
            };

            Assert.IsTrue(Utils.IsSorted(negativeSortedList));

            List<int> sortedListWithDuplicates = new List<int>()
            {
                -5, -5, 0, 2, 4, 5, 5, 6, 7
            };

            Assert.IsTrue(Utils.IsSorted(sortedListWithDuplicates));
        }
    }
}
