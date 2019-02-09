    public static String getSmallestAndLargest(String s, int k) {
       
            List<String> sub = new ArrayList<String>();  
    for(int i=0; i<=(s.length()-k); i++ ){
        sub.add(s.substring(i, k+i));
    }

    Collections.sort(sub);

    System.out.println(sub.get(0));
    System.out.println(sub.get(sub.size()-1));
    
    }
