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

    [Test]
    public void ShouldGetLongestPalindrome()
    {
        String firstInput = "babad";
        String firstExpectedOutput1 = "bab";
        String firstExpectedOutput2 = "aba";
        String firstActualOutput = StringsRelatedProblems.LongestPalindrome(firstInput);

        String secondInput = "cbbd";
        String secondExpectedOutput = "bb";
        String secondActualOutput = StringsRelatedProblems.LongestPalindrome(secondInput);

        String thirdInput = "racecar";
        String thirdExpectedOutput = "racecar";
        String thirdActualOutput = StringsRelatedProblems.LongestPalindrome(thirdInput);

        String fourthInput = "abb";
        String fourthExpectedOutput = "bb";
        String fourthActualOutput = StringsRelatedProblems.LongestPalindrome(fourthInput);

        String fifthInput = "aaaa";
        String fifthExpectedOutput = "aaaa";
        String fifthActualOutput = StringsRelatedProblems.LongestPalindrome(fifthInput);

        Assert.Multiple(() =>
        {
            Assert.That(string.Equals(firstActualOutput, firstExpectedOutput1) || string.Equals(firstActualOutput, firstExpectedOutput2), Is.True);
            Assert.That(secondActualOutput, Is.EqualTo(secondExpectedOutput));
            Assert.That(thirdActualOutput, Is.EqualTo(thirdExpectedOutput));
            Assert.That(fourthActualOutput, Is.EqualTo(fourthExpectedOutput));
            Assert.That(fifthActualOutput, Is.EqualTo(fifthExpectedOutput));
        });
    }
}