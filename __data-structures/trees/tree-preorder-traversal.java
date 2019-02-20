

/* you only have to complete the function given below.  
Node is defined as  

class Node {
    int data;
    Node left;
    Node right;
}

*/
    // have to do the iteration
    // create a stack and push the value of node in the stack, right value first
    // since right is pushed first it will be at the bottom of stack
    // the first right insertion is going to be printed last
    // how to do it with recursion
    public static void preOrder(Node root) {
        Stack<Node> st = new Stack<Node>();
        st.push(root);
        while (!st.empty()) {
            Node curNode = st.pop();
            // print
            System.out.print(curNode.data+ " ");

            if (curNode.right != null) { // first push right so at bottom
                st.push(curNode.right);
            }
            if (curNode.left != null) {
                st.push(curNode.left);
            }
        }
    }


