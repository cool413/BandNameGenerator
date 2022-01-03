using FluentAssertions;
using NUnit.Framework;

namespace UnitTest
{
    public class BandNameGeneratorTests
    {
        private BandNameGenerator.BandNameGenerator _bandNameGenerator;
        
        [SetUp]
        public void Setup()
        {
            _bandNameGenerator = new BandNameGenerator.BandNameGenerator();
        }

        [Test]
        [TestCase(null, "")]
        [TestCase("", "")]
        [TestCase(" ", "")]
        [TestCase("knife", "The Knife")]
        [TestCase("tart", "Tartart")]
        [TestCase("sandles", "Sandlesandles")]
        [TestCase("bed", "The Bed")]
        public void Can_get_bandName(string input, string expect)
        {
            var result = _bandNameGenerator.GetName(input);
            result.Should().Be(expect);
        }
    }
}