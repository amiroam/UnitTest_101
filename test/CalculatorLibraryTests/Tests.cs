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
        private readonly Guid _guid = Guid.NewGuid();
        private readonly ITestOutputHelper _outputHelper;


        public CalculatorTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }


        [Fact]  
        public void Add_ShouldAddTwoNumbers_whenTwoNumbersAreIntegers() 
        {
           
            //Act
            var result = _sut.Add(5, 3);

            //Assert
            Assert.Equal(8, result);
        }

        [Fact] 
        public void testGuid () 
        {
            _outputHelper.WriteLine($"Guid: {_guid} ");
        }


        [Fact]
        public void testGuid2()
        {
            _outputHelper.WriteLine($"Guid: {_guid} ");
        }
    }
}
