namespace LeetCodeProblems.Tests;

[TestFixture]
public class ArithmeticRealtedProblemsTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldTwoSum()
    {
        int[] firstNums = [2, 7, 11, 15];
        int firstTarget = 9;
        int[] firstExpectedOutput = [0, 1];
        var firstActualOutput = ArithmeticRelatedProblems.TwoSum(firstNums, firstTarget);

        int[] secondNums = [3, 2, 4];
        int secondTarget = 6;
        int[] secondExpectedOutput = [1, 2];
        var secondActualOutput = ArithmeticRelatedProblems.TwoSum(secondNums, secondTarget);

        int[] thirdNums = [3, 3];
        int thirdTarget = 6;
        int[] thirdExpectedOutput = [0, 1];
        var thirdActualOutput = ArithmeticRelatedProblems.TwoSum(thirdNums, thirdTarget);

        Assert.Multiple(() =>
        {
            Assert.That(firstActualOutput, Is.EqualTo(firstExpectedOutput));
            Assert.That(secondActualOutput, Is.EqualTo(secondExpectedOutput));
            Assert.That(thirdActualOutput, Is.EqualTo(thirdExpectedOutput));
        });
    }
}