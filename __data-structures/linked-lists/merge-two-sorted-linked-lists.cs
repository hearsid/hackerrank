

        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        SinglyLinkedListNode result = new SinglyLinkedListNode(0);
        // maintain head
        SinglyLinkedListNode curResultNode = result;
        while(true)
        {
            if(head1 == null)
            {
                curResultNode.next = head2;
                break;
            }
            if(head2 == null)
            {
                curResultNode.next = head1;
                break;
            }

            if(head1.data <= head2.data)
            {
                curResultNode.next = head1;
                head1 = head1.next;
            }
            else
            {
                curResultNode.next = head2;
                head2 = head2.next;
            }
            curResultNode = curResultNode.next;
        }
        return result.next;
    }


