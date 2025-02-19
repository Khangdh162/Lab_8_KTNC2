using Lab_8;
using System;
using Xunit;  // Sử dụng xUnit thay vì MSTest

namespace Test_Lab_8
{
    public class ArrayOperationsTests
    {
        private readonly ArrayOperations _arrayOperations;

        public ArrayOperationsTests()
        {
            _arrayOperations = new ArrayOperations();
        }

        [Fact]  // Thay [TestMethod] bằng [Fact]
        public void FindMax_ShouldReturnMaxValue()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = _arrayOperations.FindMax(array);
            Assert.Equal(5, result);  // Thay Assert.AreEqual bằng Assert.Equal
        }

        [Fact]  // Thay [TestMethod] bằng [Fact]
        public void FindMin_ShouldReturnMinValue()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int result = _arrayOperations.FindMin(array);
            Assert.Equal(1, result);  // Thay Assert.AreEqual bằng Assert.Equal
        }

        [Fact]  // Thay [TestMethod] bằng [Fact]
        public void FindMax_ShouldThrowExceptionWhenArrayIsEmpty()
        {
            int[] array = { };
            Assert.Throws<ArgumentException>(() => _arrayOperations.FindMax(array));  // Thay Assert.ThrowsException bằng Assert.Throws
        }

        [Fact]  // Thay [TestMethod] bằng [Fact]
        public void FindMin_ShouldThrowExceptionWhenArrayIsEmpty()
        {
            int[] array = { };
            Assert.Throws<ArgumentException>(() => _arrayOperations.FindMin(array));  // Thay Assert.ThrowsException bằng Assert.Throws
        }
    }
}
