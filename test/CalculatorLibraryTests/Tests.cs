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
         [Fact] // An attribute indicating that this method is a test method.  
        public void Add_ShouldAddTwoNumbers_whenTwoNumbersAreIntegers() // A test method to verify the Add method of the Calculator class.
        {
            // Create an instance of the Calculator class.
            //Arrange
            var calculator = new Calculator();

            // Call the Add method with two numbers (5 and 3) and store the result.
            //Act
            var result = calculator.Add(5, 3);

            // Assert that the result is equal to 8. This is a test validation step.
            Assert.Equal(8, result);
        }
    }
}
