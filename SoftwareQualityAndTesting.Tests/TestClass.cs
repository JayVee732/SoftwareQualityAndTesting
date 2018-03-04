using NUnit.Framework;
using fit;

namespace SoftwareQualityAndTesting.Tests
{
    [TestFixture]
    public class TestClass
    {
        static CalcPremiumClass c1;

        [SetUp]
        public static void Init() => c1 = new CalcPremiumClass();

        [Test(Description = "Test check not null")]
        public void CheckObject() => Assert.NotNull(c1, "Object not created");

        [TestCase(16, "female", ExpectedResult = 0)]
        [TestCase(27, "female", ExpectedResult = 5)]
        [TestCase(35, "female", ExpectedResult = 2.5)]
        [TestCase(55, "female", ExpectedResult = 0.375)]
        [TestCase(16, "male", ExpectedResult = 0)]
        [TestCase(33, "male", ExpectedResult = 6)]
        [TestCase(38, "male", ExpectedResult = 5)]
        [TestCase(53, "male", ExpectedResult = 0.75)]
        [TestCase(25, "mile", ExpectedResult = 0)]
        [TestCase(52, "famele", ExpectedResult = 0)]
        public float CheckPremium(int age, string gender)
        {
            float actualResult = c1.CalcPremium(age, gender);
            return actualResult;
        }
    }
}
