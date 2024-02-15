

namespace LeetCodeProblems;

public struct ArithmeticRelatedProblems
{
    /*
  Two Sum
  -------------------------------------------------------------------------------
  Given an array of integers nums and an integer target,
  return indices of the two numbers such that they add up to target.
  You may assume that each input would have exactly one solution,
  and you may not use the same element twice.
  You can return the answer in any order.
   */
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    return [i, j];
                }
            }
        }
        return [];
    }

    /*
      Add Two Numbers
      -------------------------------------------------------------------------------
      You are given two non-empty linked lists representing two non-negative integers.
      The digits are stored in reverse order, and each of their nodes contains a single digit.
      Add the two numbers and return the sum as a linked list.
      You may assume the two numbers do not contain any leading zero, except the number 0 itself.
       */
    public static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        ListNode resultNode = new();
        ListNode? currentNode = new();
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int firstDigit = l1 != null ? l1.Val : 0;
            int secondDigit = l2 != null ? l2.Val : 0;

            int sum = firstDigit + secondDigit + carry;
            carry = sum / 10;

            if (l1 != null)
            {
                l1 = l1.Next;
            }
            if (l2 != null)
            {
                l2 = l2.Next;
            }

            if (currentNode != null)
            {
                currentNode.Val = sum % 10;
                currentNode.Next = (l1 == null && l2 == null && carry == 0) ? null : new();
            }

            if (resultNode.Next == null && currentNode != null)
            {
                resultNode = currentNode;
            }

            currentNode = currentNode?.Next;
        }

        return resultNode;
    }
}

