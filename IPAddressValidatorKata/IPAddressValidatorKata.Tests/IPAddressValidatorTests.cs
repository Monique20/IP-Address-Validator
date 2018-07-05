using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAddressValidatorKata.Tests
{
    [TestFixture]
    public class IPAddressValidatorTests
    {
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ValidateIpv4Address_GivenAnEmptyString_ShouldReturnFalse(string input)
        {
            //Arrange
            var expected = false;
            IPAddressValidator sut = new IPAddressValidator();

            //Act
            var actual = sut.ValidateIpv4Address(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

      
        [TestCase("1")]
        public void ValidateIpv4Address_GivenASingleNumber_ShouldReturnFalse(string input)
        {
            //Arrange
            var expected = false;
            IPAddressValidator sut = new IPAddressValidator();

            //Act
            var actual = sut.ValidateIpv4Address(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1.1")]
        [TestCase("1.1.1")]
        public void ValidateIpv4Address_GivenLessThan4Numbers_ShouldReturnFalse(string input)
        {
            //Arrange
            var expected = false;
            IPAddressValidator sut = new IPAddressValidator();

            //Act
            var actual = sut.ValidateIpv4Address(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1.1.1.1")]
        [TestCase("192.168.1.1")] 
        [TestCase("10.0.0.1")]
        [TestCase("127.0.0.1")]
        public void ValidateIpv4Address_Given4Numbers_ShouldReturnTrue(string input)
        {
            //Arrange
            var expected = true;
            IPAddressValidator sut = new IPAddressValidator();

            //Act
            var actual = sut.ValidateIpv4Address(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("127.0.0.0")]
        [TestCase("127.0.0.255")]
        [TestCase("255.255.255.255")]
        public void ValidateIpv4Address_Given4NumbersEndingWith0_ShouldReturnFalse(string input)
        {
            //Arrange
            var expected = false;
            IPAddressValidator sut = new IPAddressValidator();

            //Act
            var actual = sut.ValidateIpv4Address(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
