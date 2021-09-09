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

        }

        [Fact]
        public void Main_takes_input()
        {
            foreach (string correct in new string[] {"2000", "1600"}) {
                var writer = new StringWriter();
                Console.SetOut(writer);
                Console.SetIn(new StringReader(correct));

                Program.Main(new string[0]);

                var output = writer.GetStringBuilder().ToString().Trim();
                Assert.Equal("yay", output);
            }

            foreach (string incorrect in new string[] {"2100", "2001", "1655"}) {
                var writer = new StringWriter();
                Console.SetOut(writer);
                Console.SetIn(new StringReader(incorrect));

                Program.Main(new string[0]);

                var output = writer.GetStringBuilder().ToString().Trim();
                Assert.Equal("nay", output);
            }   
        }
    }
}
