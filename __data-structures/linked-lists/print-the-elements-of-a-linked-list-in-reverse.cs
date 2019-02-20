

    // Complete the reversePrint function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static void reversePrint(SinglyLinkedListNode head) {
        // push it in stack and print the stack
        Stack<int> llElements = new Stack<int>();
        if(head != null) {
            while(head != null) {
                llElements.Push(head.data);
                head = head.next;
            }
        }

        if(llElements.Count() > 0) {
            while(llElements.Count >0) {
                Console.WriteLine(llElements.Pop());
            }
        }

    }


