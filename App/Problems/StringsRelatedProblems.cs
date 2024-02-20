
using System.Data.Common;

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
        rightBound = i + radius - 1;
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
        s[i + radius] == s[i - radius - 1])
      {
        radius++;
      }
      evenRadii[i] = radius;
      if (i + radius - 1 > radius)
      {
        leftBound = i - radius;
        rightBound = i + radius - 1;
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

  /*
  Zigzag Conversion
  -------------------------------------------------------------------------------
  The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows (3) like this:
  (you may want to display this pattern in a fixed font for better legibility)
  P   A   H   N
  A P L S I I G
  Y   I   R
  And then read line by line: "PAHNAPLSIIGYIR"
    4 rows:
  P     I    N
  A   L S  I G
  Y A   H R
  P     I
  And then read line by line: "PINALSIGYAHRPI"
  Write the code that will take a string and make this conversion given a number of rows:
  string convert(string s, int numRows);
  Solution:
  Let replace chars by indexes for convinience:
  1       9           17
  2     8 10       16 18
  3   7   11    15    19
  4 6     12 14       20
  5       13          21 ...
  The distribution of chars by COLUMNS in a given zigzag configuration obeys the formula: 
  charIndex + (numRows * 2 - 2)
  where: 
    charIndex - the current index of the char in each column 1, 9, 17, 2, 10, 18, 3, 11,...
    numRows - the constant given in params.
    (numRows * 2 - 2) is the fixed column shift depends on numRows.
  In this example numRows = 5 so char index for second row: 1 + (5 * 2 - 2) = 9
  third: 9 + (5 * 2 - 2) = 17
  The distribution of chars by DIAGONALS in a given zigzag configuration obeys the formula: 
  columnIndex - (row - 1) * 2
  where:
    columnIndex - calculated before
    row - the number of current row: 1, 2, 3,...
    columnIndex - (row - 1) * 2 or columnIndex - (row * 2 - 2) - is the fixed diagonal shift 
    depends on number of the current row. 
    For second row: columnIndex = 2 + (5 * 2 - 2) = 10; diagonalIndex = 10 - (2 * 2 - 2) = 8
   */
  public static string ZigzagConvert(string s, int numRows)
  {
    char[] zigZag = new char[s.Length];
    int zigZagIndex = 0; // Start saving to array from 0
    for (int r = 1; r <= numRows; r++) // Start from 1 to simplify thinking
    {
      int charIndex = r;
      while (charIndex <= s.Length && zigZagIndex < s.Length)
      {
        zigZag[zigZagIndex++] = s[charIndex - 1];
        int columnShift = Math.Max(numRows * 2 - 2, 1); // 1 for cases where numRows is 1
        int columnIndex = charIndex + columnShift;
        charIndex = columnIndex;

        int diagonalShift = r * 2 - 2;
        int diagonalIndex = columnIndex - diagonalShift;
        if (diagonalShift > 0 && diagonalShift < columnShift && diagonalIndex <= s.Length)
        {
          zigZag[zigZagIndex++] = s[diagonalIndex - 1];
        }

      }
    }
    return string.Join("", zigZag);
  }
}