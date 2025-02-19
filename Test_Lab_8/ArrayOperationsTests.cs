using Lab_8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Test_Lab_8
{
    [TestClass]
    public class ArrayOperationsTests
    {
        private readonly ArrayOperations _arrayOperations;

        public ArrayOperationsTests()
        {
            _arrayOperations = new ArrayOperations();
        }

        [TestMethod]
        public void FindMax_ShouldReturnMaxValue()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = _arrayOperations.FindMax(array);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void FindMin_ShouldReturnMinValue()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = _arrayOperations.FindMin(array);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void FindMax_ShouldThrowExceptionWhenArrayIsEmpty()
        {
            int[] array = { };
            Assert.ThrowsException<ArgumentException>(() => _arrayOperations.FindMax(array));
        }

        [TestMethod]
        public void FindMin_ShouldThrowExceptionWhenArrayIsEmpty()
        {
            int[] array = { };
            Assert.ThrowsException<ArgumentException>(() => _arrayOperations.FindMin(array));
        }
    }
}
