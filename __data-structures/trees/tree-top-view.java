

	/* 
    
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/

    // max left or max ryt nodes from top like a mountain
	public static void topView(Node root) {
      int maxMountainChainLeft = traverseTreeL(root);
      int maxMountainChainRight = traverseTreeR(root);
      Node node = root;
      if(maxMountainChainLeft> maxMountainChainRight) {
          while(true) {
              if(node != null) {
                System.out.print(node.data+" ");
                node = node.left;
              } else {
                  break;
              }
          }
      } else {
          while(true) {
              if(node != null) {
                System.out.print(node.data+ " ");
                node = node.right;
              } else {
                  break;
              }
          }
      }
    }

    public static int traverseTreeR(Node root) {
        if(root.right != null)
            return 1+ traverseTreeR(root.right);
        
        return 0;
    }

    public static int traverseTreeL(Node root) {
        if(root.left != null)
            return 1+ traverseTreeL(root.left);
        
        return 0;
    }


