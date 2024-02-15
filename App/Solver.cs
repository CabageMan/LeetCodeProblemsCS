namespace LeetCodeProblems;

class Solver
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let solve it!");
        ListNode firstNode = new(2, new(4));
        ListNode secondNode = new(5, new(6, new(4)));
        ListNode thirdNode = new(0);
        Console.WriteLine($"Array from node {string.Join(",", secondNode.ToArray())}");
    }
}
