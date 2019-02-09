import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        boolean isPalindrom = false;
        if(A.length()>50) {
            return;
        }
        /* Enter your code here. Print output to STDOUT. */
        for(int i= 0; i < A.length(); i++) {
            if(A.charAt(i) == A.charAt(A.length()-i-1)) {
                isPalindrom = true;
            } else {
                isPalindrom = false;
            }
        }
        
        System.out.println(isPalindrom? "Yes": "No");
        
    }
}




