    static boolean isAnagram(String a, String b) {
        char[] aChars = a.toCharArray();
        char[] bChars = b.toCharArray();
        
        if(a.length() != b.length())
            return false;
        int matchingCharsLength = 0;
         for(int i = 0; i<aChars.length; i++) {
            char currentChar = aChars[i];
            for(int j=0; j<bChars.length; j++) {
                char jCurrentChar = bChars[j];
                if(currentChar == jCurrentChar) {
                    matchingCharsLength+=1;
                    break;
                } 
            }
            
        }
        
        if(matchingCharsLength == aChars.length) 
            return true;
        else 
            return false;
    }

 


