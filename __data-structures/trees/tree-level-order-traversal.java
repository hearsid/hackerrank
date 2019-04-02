

	/* 
    
    class Node 
    	int data;
    	Node left;
    	Node right;
	*/
	public static void levelOrder(Node root,int flag) {
        // no easy way to do with recurssion
      if(flag == 0){
        flag = 1;
        System.out.println(root.data);
      }
      else if(flag == 1) {
        flag = 2;
        levelOrder(root.left, flag);
      } 
      
    }


