using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary; // Importing the CalculatorLibrary namespace to access the Calculator class.

namespace CalculatorLibrary.Tests.Unit // Namespace for the test project.
{
    public class CalculatorTests // A class containing test methods for the Calculator class.
    {
        private readonly Calculator _sut = new (); // A private readonly field for the System Under Test (SUT), which is an instance of the Calculator class.
        [Fact] // An attribute indicating that this method is a test method.  
        public void Add_ShouldAddTwoNumbers_whenTwoNumbersAreIntegers() // A test method to verify the Add method of the Calculator class.
        {
            // Create an instance of the Calculator class.
            //Act
            var result = _sut.Add(5, 3);

            // Assert that the result is equal to 8. This is a test validation step.
            Assert.Equal(8, result);
        }
    }
}
