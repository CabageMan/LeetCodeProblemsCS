namespace LeetCodeProblems.Tests;

[TestFixture]
public class StringsRelatedProblemsTests
{
    [Test]
    public void ShouldGetLengthOfLongestSubstring()
    {
        // Explanation: The answer is "abc", with the length of 3.
        string firstInput = "abcabcbb";
        int firstExpectedOutput = 3;
        int firstActualOutput = StringsRelatedProblems.LengthOfLongestSubstring(firstInput);

        // Explanation: The answer is "b", with the length of 1.
        string secondInput = "bbbbb";
        int secondExpectedOutput = 1;
        int secondActualOutput = StringsRelatedProblems.LengthOfLongestSubstring(secondInput);

        // Explanation: The answer is "wke", with the length of 3.
        String thirdInput = "pwwkew";
        int thirdExpectedOutput = 3;
        int thirdActualOutput = StringsRelatedProblems.LengthOfLongestSubstring(thirdInput);

        Assert.Multiple(() =>
        {
            Assert.That(firstActualOutput, Is.EqualTo(firstExpectedOutput));
            Assert.That(secondActualOutput, Is.EqualTo(secondExpectedOutput));
            Assert.That(thirdActualOutput, Is.EqualTo(thirdExpectedOutput));
        });
    }
}