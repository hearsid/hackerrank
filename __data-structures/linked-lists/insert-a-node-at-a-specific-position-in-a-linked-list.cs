

    // Complete the insertNodeAtPosition function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) {
        int i = 1;
        SinglyLinkedListNode node = new SinglyLinkedListNode(data);
        SinglyLinkedListNode curNode = head;
        while(curNode.next != null) {
            if(i == position) {
                SinglyLinkedListNode tempNode = curNode.next;
                curNode.next = node;
                node.next = tempNode;
            }
            curNode = curNode.next;
            i++;
        }
    return head;
    }


