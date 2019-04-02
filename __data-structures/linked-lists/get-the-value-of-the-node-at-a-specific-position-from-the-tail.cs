

    // Complete the getNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static int getNode(SinglyLinkedListNode head, int positionFromTail) {
        
        int curIndex = 0;
        SinglyLinkedListNode current = head;
        SinglyLinkedListNode result = head;
        while(current != null)
        {
            current=current.next;
            if (curIndex++ > positionFromTail)
            {
                result=result.next;
            }
        }
        return result.data;
    }


