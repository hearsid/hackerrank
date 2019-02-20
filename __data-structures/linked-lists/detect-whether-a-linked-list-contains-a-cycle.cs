

    // Complete the hasCycle function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static bool hasCycle(SinglyLinkedListNode head)
    {
        // 
        Dictionary<int, int> llelems= new Dictionary<int, int>();
        while(head != null)
        {
            int hs = head.GetHashCode();
            if(!llelems.ContainsKey(hs))
                llelems.Add(hs, head.data);
            else {
                return true;
            }
            head = head.next;
        }

        return false;
    }


