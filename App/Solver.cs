namespace LeetCodeProblems;

class Solver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let solve it!");
        
        // Explanation: merged array = [1,2,3] and median is 2.
        int[] firstNums1 = [1, 3];
        int[] firstNums2 = [2];
        double firstExpectedOutput = 2.0;
        double firstActualOutput = ArithmeticRelatedProblems.FindMedianSortedArrays(firstNums1, firstNums2);
        Console.WriteLine($"Substring length {firstActualOutput}");
    }
}
