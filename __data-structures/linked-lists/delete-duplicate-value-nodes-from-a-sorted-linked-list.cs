

    // Complete the removeDuplicates function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head) {
         if (head == null)
            return head;

        SinglyLinkedListNode curPointer = head;
        while (head != null)
        {
            if (head == null || head.next == null)
                break;

            int curVal = head.data;
            int nextVal = head.next.data; // if next not there then error
            if (curVal == nextVal)
            {

                head.next = head.next.next;
            }
            else
            {

                head = head.next;
            }
            
        }
        return curPointer;

    }


