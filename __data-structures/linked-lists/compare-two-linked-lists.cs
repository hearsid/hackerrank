

    // Complete the CompareLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */

    static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {

        if(head1 == null && head2 == null)
            return true;

        if(head1 != null && head2 != null) {
  
            for(int i=0;;i++) {
                if(head1 == null && head2 != null)
                    return false;

                if(head1 != null && head2 == null)
                    return false;

                if(head1 == null && head2 == null)
                    return true;
                
                int dataOne = head1.data;
                int dataTwo = head2.data;
                
                if(dataOne == dataTwo) {
                    head1 = head1.next;
                    head2 = head2.next;
                    continue;
                } else {
                    return false;
                }
            }
            return true;
        } else {
            return false;
        }
        return false;
    }


