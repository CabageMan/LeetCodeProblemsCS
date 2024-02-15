namespace LeetCodeProblems;

public class ListNode(int val = 0, ListNode? next = null)
{
    private int _val = val;
    private ListNode? _next = next;

    public int Val { 
        get => _val;
        set => _val = value;
    }
    public ListNode? Next { 
        get => _next; 
        set => _next = value; 
    }

    public int[] ToArray() => ListNodeToArray(this, []);

    public static int[] ListNodeToArray(ListNode listNode, int[] resultArray)
    {
        int[] currentArray = new int[resultArray.Length + 1];
        int i = 0;
        foreach (int number in resultArray)
        {
            currentArray[i] = number;
            i++;
        }
        currentArray[i] = listNode.Val;

        if (listNode.Next == null)
        {
            return currentArray;
        }

        return ListNodeToArray(listNode.Next, currentArray);
    }
}