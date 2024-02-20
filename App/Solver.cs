namespace LeetCodeProblems;

class Solver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let solve it!");

        // String zeroInput = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij";
        // String zeroInput = "PAYPALISHIRING";

        String zeroInput = "AB";
        
        int zeroNumRows = 1;
        String zeroExpectedOutput = "";
        String zeroActualOutput = StringsRelatedProblems.ZigzagConvert(zeroInput, zeroNumRows);

        Console.WriteLine($"ZigZag: {zeroActualOutput}");
    }
}
