using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TextMatch.Tests
{
    [TestFixture]
    public class TextMatchTests
    {
        [Test]
        public void Should_Find_Correct_Position_When_Text_Has_2_Words()
        {
            var text = "Hello world";
            var subText = "world";

            var result = TextMatch.Find(text, subText);
            var expectedResult = "7";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Find_Correct_Positions_When_Text_Has_5_Words()
        {
            var text = "Hello world hello world hello";
            var subText = "world";

            var result = TextMatch.Find(text, subText);
            var expectedResult = "7,19";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Find_Correct_Positions_When_Text_Is_Long()
        {
            var text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            var subText = "Polly";

            var result = TextMatch.Find(text, subText);
            var expectedResult = "1,26,51";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Find_Correct_Positions_When_Text_Is_Long_2()
        {
            var text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            var subText = "ll";

            var result = TextMatch.Find(text, subText);
            var expectedResult = "3,28,53,78,82";

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Should_Return_Nothng_If_There_Is_No_Match()
        {
            var text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea";
            var subText = "world";

            var result = TextMatch.Find(text, subText);
            var expectedResult = "";

            Assert.AreEqual(expectedResult, result);
        }
    }
}
