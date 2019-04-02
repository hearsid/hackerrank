

    // Complete the insertNodeAtTail function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
      static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
    {
    SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
        SinglyLinkedListNode curNode = head;
        if (head == null)
        {
            return newNode;
        }
        else
        {
            while(curNode.next != null)
            {
                curNode = curNode.next;
            }
            curNode.next = newNode;
        }
        return head;
    }
       


