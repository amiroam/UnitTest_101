using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using FluentAssertions;
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

        public void Add_ShouldAddTwoNumbers_whenTwoNumbersAreIntegers(
            int a, int b, int expected)    
        {

            //Act
            var result = _sut.Add(a,b);

            //Assert
            result.Should().Be(expected); 
           
        }

      
    }
}
