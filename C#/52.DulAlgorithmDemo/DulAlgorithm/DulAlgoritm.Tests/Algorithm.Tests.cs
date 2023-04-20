using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulAlgoritm.Tests
{
    class Algorithm
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
        public class AlgorithmClassTest
        {
            [TestMethod]
            public void MyTestMethod()
            {
                Assert.AreEqual(10, 10);
            }
            
            [TestMethod]
            public void SelectionSort_ShouldReturnSortedArray()
            {
                //[1] Arrange(정렬), SetUp
                int[] arr = { 33, 22, 44 };

                //[2] Act(동작), Execute
                int[] results = DulAlgorithm.Algorithm.SelectionSort(arr);

                //[3] Assert(어설션), Verify
                Assert.AreEqual(22, results[0]); // true
                Assert.AreEqual(44, results[results.Length - 1]); // true
            }
        }
    }
}
