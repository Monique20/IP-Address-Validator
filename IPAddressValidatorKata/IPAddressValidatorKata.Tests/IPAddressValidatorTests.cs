using NUnit.Framework;

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
            var nullOrEmpty =  new NullOrEmpty();
            var notFourOctets = new NotFourOctets();
            var notValidHost = new NotAValidHost();

            nullOrEmpty.SetSuccessor(notFourOctets);
            notFourOctets.SetSuccessor(notValidHost);

            //Act
            var actual = nullOrEmpty.Parse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1")]
        [TestCase("1.1")]
        [TestCase("1.1.1")]
        [TestCase("10.0.1")]
        [TestCase("10.0.1.6.3.4")]
        public void ValidateIpv4Address_GivenLessThan4GroupsOfNumbers_ShouldReturnFalse(string input)
        {
            //Arrange
            var expected = false;
            var nullOrEmpty = new NullOrEmpty();
            var notFourOctets = new NotFourOctets();
            var notValidHost = new NotAValidHost();

            nullOrEmpty.SetSuccessor(notFourOctets);
            notFourOctets.SetSuccessor(notValidHost);

            //Act
            var actual = nullOrEmpty.Parse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1.1.1.1")]
        [TestCase("192.168.1.1")] 
        [TestCase("10.0.0.1")]
        [TestCase("127.0.0.30")]
        public void ValidateIpv4Address_Given4GroupsOfNumbers_ShouldReturnTrue(string input)
        {
            //Arrange
            var expected = true;
            var nullOrEmpty = new NullOrEmpty();
            var notFourOctets = new NotFourOctets();
            var notValidHost = new NotAValidHost();

            nullOrEmpty.SetSuccessor(notFourOctets);
            notFourOctets.SetSuccessor(notValidHost);

            //Act
            var actual = nullOrEmpty.Parse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("1.1.1.0")]
        [TestCase("127.0.0.0")]
        [TestCase("127.0.0.255")] 
        [TestCase("255.255.255.255")]
        public void ValidateIpv4Address_Given4NumbersEndingWith0_ShouldReturnFalse(string input)
        {
            //Arrange
            var expected = false;
            var nullOrEmpty = new NullOrEmpty();
            var notFourOctets = new NotFourOctets();
            var notValidHost = new NotAValidHost();

            nullOrEmpty.SetSuccessor(notFourOctets);
            notFourOctets.SetSuccessor(notValidHost);

            //Act
            var actual = nullOrEmpty.Parse(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
