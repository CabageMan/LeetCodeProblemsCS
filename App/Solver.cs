namespace LeetCodeProblems;

class Solver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let solve it!");

        // Explanation: The answer is "abc", with the length of 3.
        string firstInput = "abcabcbb";
        int firstActualOutput = StringsRelatedProblems.LengthOfLongestSubstring(firstInput);
        Console.WriteLine($"Substring length {firstActualOutput}");
    }
}
