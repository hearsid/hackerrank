

    // Complete the reverse function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode reverse(SinglyLinkedListNode head) {
        // push the values in stack and create a new LL
         Stack<int> llElements = new Stack<int>();
        if (head != null)
        {
            while (head != null)
            {
                llElements.Push(head.data);
                head = head.next;
            }
        }
        SinglyLinkedList newLL = new SinglyLinkedList();
        if (llElements.Count() > 0)
        {
            int val = llElements.Pop();
            SinglyLinkedListNode root = new SinglyLinkedListNode(val);
            SinglyLinkedListNode rootCopy = root;
            while (llElements.Count > 0)
            {
                int val2 = llElements.Pop();
                SinglyLinkedListNode node = new SinglyLinkedListNode(val2);
                rootCopy.next = node;
                rootCopy = rootCopy.next;
            }
                    return root;

        }
            return head;
    }


