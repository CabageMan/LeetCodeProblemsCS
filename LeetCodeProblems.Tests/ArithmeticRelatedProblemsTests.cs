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

    [Test]
    public void ShouldAddTwoNumbers()
    {
        /*
        Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
        Output: [7, 0, 8]
         */
        ListNode firstInputL1 = new(2, new(4, new(3)));
        ListNode firstInputL2 = new(5, new(6, new(4)));
        ListNode firstExpectedOutput = new(7, new(0, new(8)));
        var firstActualOutput = ArithmeticRelatedProblems.AddTwoNumbers(firstInputL1, firstInputL2);

        /*
        Input: l1 = [0], l2 = [0]
        Output: [0]
         */
        ListNode secondInputL1 = new(0);
        ListNode secondInputL2 = new(0);
        ListNode secondExpectedOutput = new(0);
        var secondActualOutput = ArithmeticRelatedProblems.AddTwoNumbers(secondInputL1, secondInputL2);

        /*
        Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        Output: [8,9,9,9,0,0,0,1]
         */
        ListNode thirdInputL1 = new(9, new(9, new(9, new(9, new(9, new(9, new(9)))))));
        ListNode thirdInputL2 = new(9, new(9, new(9, new(9))));
        ListNode thirdExpectedOutput = new(8, new(9, new(9, new(9, new(0, new(0, new(0, new(1))))))));
        var thirdActualOutput = ArithmeticRelatedProblems.AddTwoNumbers(thirdInputL1, thirdInputL2);

        Assert.Multiple(() =>
        {
            Assert.That(firstActualOutput.ToArray().SequenceEqual(firstExpectedOutput.ToArray()), Is.True);
            Assert.That(secondActualOutput.ToArray().SequenceEqual(secondExpectedOutput.ToArray()), Is.True);
            Assert.That(thirdActualOutput.ToArray().SequenceEqual(thirdExpectedOutput.ToArray()), Is.True);
        });
    }
}