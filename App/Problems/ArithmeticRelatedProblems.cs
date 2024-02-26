

using System.ComponentModel;

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

    /*
    Median of Two Sorted Arrays
    -------------------------------------------------------------------------------
    Given two sorted arrays nums1 and nums2 of size m and n respectively,
    return the median of the two sorted arrays.
    The overall run time complexity should be O(log (m+n)).
    */
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int counterOfNums1 = 0;
        int counterOfNums2 = 0;
        int counterOfMerged = 0;
        int totalLength = nums1.Length + nums2.Length;
        int[] mergedArray = new int[totalLength];

        while (counterOfNums1 < nums1.Length && counterOfNums2 < nums2.Length)
        {
            mergedArray[counterOfMerged++] = nums1[counterOfNums1] < nums2[counterOfNums2]
                ? nums1[counterOfNums1++] : nums2[counterOfNums2++];
        }
        while (counterOfNums1 < nums1.Length)
        {
            mergedArray[counterOfMerged++] = nums1[counterOfNums1++];
        }
        while (counterOfNums2 < nums2.Length)
        {
            mergedArray[counterOfMerged++] = nums2[counterOfNums2++];
        }

        if (totalLength % 2 != 0)
        {
            return mergedArray[(int)Math.Round((double)(totalLength - 1) / 2)];
        }
        else
        {
            int centralIndex = totalLength / 2;
            return (double)(mergedArray[centralIndex - 1] + mergedArray[centralIndex]) / 2;
        }
    }

    /*
    Given a signed 32-bit integer x, return x with its digits reversed. 
    If reversing x causes the value to go outside the signed 32-bit integer 
    range [-2^31, 2^31 - 1], then return 0.
    Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
    Example 1:
    Input: x = 123
    Output: 321
    
    Example 2:
    Input: x = -123
    Output: -321

    Example 3:
    Input: x = 120
    Output: 21
    */
    public static int ReverseInteger(int x)
    {
        try
        {
            int signNumb = x < 0 ? -1 : 1;
            string numberString = Math.Abs(x).ToString();
            var reversedString = new string(numberString.ToCharArray().Reverse().ToArray());
            return int.Parse(reversedString) * signNumb;
        }
        catch (OverflowException e)
        {
            Console.WriteLine($"The reversed number is out of Int32 bounds: {e.Message}");
            return 0;
        }
    }
}

