

    // lets do it with a data structure and then recursion
    // print only when the left and right of a node is null

    public static void postOrder(Node root) {
        if(root != null) {
            postOrder(root.left); // keeps going to leftmost node without printing
            postOrder(root.right);
            System.out.print(root.data+" ");
        }

    }

