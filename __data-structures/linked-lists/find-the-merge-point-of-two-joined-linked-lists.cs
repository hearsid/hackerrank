

    // Complete the findMergeNode function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        // merge point? first same value, if not address
        int result = 0 ;
        while(head1 != null && head2 != null) {
            if(head1.GetHashCode() == head2.GetHashCode()) {
                result =  head1.data;
                break;
            }

            head1 = head1.next;
            head2 = head2.next;
        }
        return result;

    }


