using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Resurstillf.Test
{
    [TestClass]
    public class FunExamplesTests
    {
        [TestMethod]
        public void ContainsCoffeeOnlyCoffeeInputReturnsTrue()
        {
            //Arrange
            string value = "coffee";
            bool expected = true;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ContainsCoffeeLowerCaseCapitalsReturnsTrue()
        {
            //Arrange
            string value = "Would you like some coffee, my dear?";
            bool expected = true;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ContainsCoffeeUpperCaseCapitalsReturnsTrue()
        {
            //Arrange
            string value = "Would you like some COFFEE, my dear?";
            bool expected = true;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ContainsCoffeeWithNumbersInputReturnsTrue()
        {
            //Arrange
            string value = "Would you like 2 cups of coffee, my dear?";
            bool expected = true;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ContainsCoffeeInWordInputReturnsFalse()
        {
            //Arrange
            string value = "Would you like a supercoffeemachine, my dear?";
            bool expected = false;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void ContainsCoffeeMissingLetterInputReturnsFalse()
        {
            //Arrange
            string value = "Would you like some coffe, my dear?";
            bool expected = false;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ContainsCoffeeMixedCapitalsInputReturnsTrue()
        {
            //Arrange
            string value = "Would you like some cOFfeE, my dear?";
            bool expected = true;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void ContainsCoffeeInternationalLettersInputReturnsFalse()
        {
            //Arrange
            string value = "coffëé";
            bool expected = false;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ContainsCoffeStringWithoutCoffeeInputReturnsFalse()
        {
            //Arrange
            string value = "Would you like some tea, my friend?";
            bool expected = false;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsCoffeeEmptyStringInputReturnsFalse()
        {
            //Arrange
            string value = "";
            bool expected = false;

            //Act
            bool actual = FunExamples.ContainsCoffee(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsCoffeNullInputThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            try
            {
                //Act
                bool actual = FunExamples.ContainsCoffee(value);

                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                // Test passes!
            }
            catch 
            {
                Assert.Fail();
            }
            
        }



        
    }
}
