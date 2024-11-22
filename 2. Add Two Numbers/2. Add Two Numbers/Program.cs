// See https://leetcode.com/problems/add-two-numbers/description/

using _2._Add_Two_Numbers;

//     
// Example 2:
//
// Input: l1 = [0], l2 = [0]
// Output: [0]
//
// Example 3:
//
// Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
// Output: [8,9,9,9,0,0,0,1]

public class Program
{  
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        ListNode headResult = new ListNode();
        ListNode currentNode = headResult;
        
        while (l1 != null || l2 != null || carry > 0)
        {
            int val1 = l1?.val ?? 0;
            int val2 = l2?.val ?? 0;
            
            int sum = val1 + val2 + carry;
            carry = sum / 10;
            
            currentNode.next = new ListNode(sum % 10);
            currentNode = currentNode.next;
            
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (carry > 0) currentNode.next = new ListNode(carry);

        return headResult.next;
    }

    private static ListNode CreateList(int[] values)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        foreach (int value in values)
        {
            current.next = new ListNode(value);
            current = current.next;
        }
        
        return dummy.next;
    }
    
    private static void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val);
            if (node.next != null) Console.Write(" -> ");
            node = node.next;
        }
        Console.WriteLine();
    }
    
    public static void Main()
    {
        ListNode l1 = CreateList(new[] { 2, 4, 3 });
        ListNode l2 = CreateList(new[] { 5, 6, 4 });
        
        var solution = new Program();
        ListNode result = solution.AddTwoNumbers(l1, l2);
        
        PrintList(result); 
    }
}