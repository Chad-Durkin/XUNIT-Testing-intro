using Xunit;
using System;
using System.Collections.Generic;
using LeetSpeakGenerator.Objects;

namespace LeetSpeakGeneratorTest
{
    public class LeetSpeakTest
    {
        [Fact]
        public void IsPlainText_ConvertAToFour()
        {
            //arrange
            string userInput = "hey what";
            string expected = "|-|3¥ VV|-|47";
            // LeetSpeak testObject = new LeetSpeak(userInput);
            //act
            string output = LeetSpeak.ArrayConversion(userInput);
            //assert
            Assert.Equal(expected, output);
        }
    }
}
