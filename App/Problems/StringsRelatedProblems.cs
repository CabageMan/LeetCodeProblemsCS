
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

  /*
  Longest Palindromic Substring
  -------------------------------------------------------------------------------
  Given a string s, return the longest palindromic (A string is palindromic if it
  reads the same forward and backward.) substring in s.
  */
  // Manacher's algorithm
  public static string LongestPalindrome(string s)
  {
    var stringLength = s.Length;
    int[] oddRadii = new int[stringLength];
    int[] evenRadii = new int[stringLength];

    int leftBound = 0;
    int rightBound = -1;
    for (int i = 0; i < stringLength; i++)
    {
      int radius = i > rightBound 
        ? 1 
        : Math.Min(oddRadii[leftBound + rightBound - i], rightBound - i + 1);
      while (
        (i + radius) < stringLength &&
        (i - radius) >= 0 &&
        s[i + radius] == s[i - radius])
      {
        radius++;
      }
      oddRadii[i] = radius;
      if (i + radius - 1 > rightBound)
      {
        leftBound = i - radius + 1;
        rightBound = i + radius -1;
      }
    }

    leftBound = 0;
    rightBound = -1;
    for (int i = 0; i < stringLength; i++)
    {
      int radius = i > rightBound
        ? 0
        : Math.Min(evenRadii[leftBound + rightBound - i + 1], rightBound - i + 1);
      while (
        (i + radius) < stringLength &&
        (i - radius - 1) >= 0 &&
        s[i + radius] == s[i -radius - 1])
      {
        radius++;
      }
      evenRadii[i] = radius;
      if (i + radius - 1 > radius)
      {
        leftBound = i - radius;
        rightBound = i + radius -1;
      }
    }

    var (oddRadius, oddCenter) = oddRadii
      .Select((oddRadius, oddCenter) => (oddRadius, oddCenter))
      .Max();
    var (evenRadius, evenCenter) = evenRadii
      .Select((evenRadius, evenCenter) => (evenRadius, evenCenter))
      .Max();

    if (oddRadius > evenRadius)
    {
      int startIndex = oddCenter - oddRadius + 1;
      int endIndex = oddCenter + oddRadius;
      return s[startIndex..endIndex];
    }
    else
    {
      int startIndex = evenCenter - evenRadius;
      int endIndex = evenCenter + evenRadius;
      return s[startIndex..endIndex];
    }
  }
}