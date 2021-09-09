using System;
using System.IO;
using Xunit;

namespace BoilerPlate.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_Checks_Leap_Year()
        {
            //Arrange
            var method = new Program();
            var fail = 1900;
            var success1 = 2000;
            var success2 = 8;

            //Act
            var giveFalse = method.IsLeapYear(fail);
            var giveTrue1 = method.IsLeapYear(success1);
            var giveTrue2 = method.IsLeapYear(success2);

            //Assert
            Assert.False(giveFalse);
            Assert.True(giveTrue1);
            Assert.True(giveTrue2);

            Console.WriteLine("jdwnajdnajfnekajnncjkadncjkndjkacndjknakjncdjan");
        }
    }
}
