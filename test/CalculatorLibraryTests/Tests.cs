using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit 
{
    public class CalculatorTests :IDisposable 
    {
        private readonly Calculator _sut = new();  
        private readonly ITestOutputHelper _outputHelper;

        //Setup Goes Here
        public CalculatorTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _outputHelper.WriteLine("Hello From Constructor");
        }

      

        [Fact]  
        public void Add_ShouldAddTwoNumbers_whenTwoNumbersAreIntegers() 
        {
           
            //Act
            var result = _sut.Add(5, 3);

            //Assert
            Assert.Equal(8, result);

            _outputHelper.WriteLine("Hello From Add");
        }

        [Fact]
        public void Subtract_ShouldSubtractTwoNumbers_whenTwoNumbersAreIntegers()
        {
            //Act
            var result = _sut.Subtract(5, 3);
            //Assert
            Assert.Equal(2, result);
            _outputHelper.WriteLine("Hello From Subtract");
        }
        public void Dispose() 
        {
            _outputHelper.WriteLine("Hello From Cleanup");
        }
    }
}
