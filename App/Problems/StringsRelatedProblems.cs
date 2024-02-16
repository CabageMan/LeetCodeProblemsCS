
namespace LeetCodeProblems;

public struct StringsRelatedProblems
{
  /*
Longest Substring Without Repeating Characters
-------------------------------------------------------------------------------
Given a string s, find the length of the longest substring
without repeating characters.
 */
  public static int LengthOfLongestSubstring(string s)
  {
    List<char> chars = [];
    int maxLength = 0;
    for (int i = 0; i < s.Length; i++)
    {
      var currentChar = s[i];
      int existedCharIndex = chars.IndexOf(currentChar);
      if (existedCharIndex > -1)
      {
        chars.RemoveRange(0, Math.Min(existedCharIndex + 1, chars.Count));
      }
      chars.Add(currentChar);
      if (chars.Count > maxLength)
      {
        maxLength = chars.Count;
      }
    }

    return maxLength;
  }
}