using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit 
{
    public class CalculatorTests 
    {
        private readonly Calculator _sut = new();  
        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(0, 0, 0)]
        [InlineData(7, 3, 10)]
        [InlineData(51, 3, 54)]
        // This test method verifies that the Add method in the Calculator class 
        // correctly adds two integer numbers and returns the expected
        // It uses the [Theory] attribute to test multiple input values (a, b) 
        // and their expected output (expected).
        public void Add_ShouldAddTwoNumbers_whenTwoNumbersAreIntegers(
            int a, int b, int expected)    
        {

            //Act
            var result = _sut.Add(a,b);

            //Assert
            Assert.Equal(expected, result);

           
        }

      
    }
}
