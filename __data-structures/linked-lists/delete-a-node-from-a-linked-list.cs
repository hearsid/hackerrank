

    // Complete the deleteNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {

        // for testcase 2
        if(position ==0)
            return head.next;
            
        // keep ref of cur node to avoid manipulating head ref
        SinglyLinkedListNode curNode = head;
        if(head != null) {
            int curPos = 1;
            while(curNode != null) {
                if(curPos == position) {
                    SinglyLinkedListNode temp = curNode;
                 //   temp.data = null;
                    curNode.next = temp.next.next;
                    break;
                }
                curNode = curNode.next;
                curPos+=1;

            }
        }
        return head;
    }


