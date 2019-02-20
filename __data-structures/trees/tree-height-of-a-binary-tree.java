

	/*
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static int height(Node root) {
      	// Write your code here.
        // apply traversal and set the max height by that
        // which traversal? 
        // pre order 
        int maxHeight = preOrder(root, 0)-1; // added -1 to adjust o/p, must be node couting issue
        return maxHeight;
    }

    public static int preOrder(Node root, int maxHeight) {
        if(root != null) {
            int heightL = preOrder(root.left, maxHeight);
            int heightR = preOrder(root.right, maxHeight);
            if(heightL >= heightR) {
                return 1+ heightL;
            } else if (heightR > heightL) {
                return 1+heightR;
            } 
        } else {
            return 0;
        }
        return 0;
    }


