import java.io.*;
import java.util.*;

public class Solution {

     static String capitalize(String word) {
        return word.substring(0,1).toUpperCase()+word.substring(1);
    }
    public static void main(String[] args) {
        
        Scanner sc=new Scanner(System.in);
        String A=sc.next();
        String B=sc.next();
        /* Enter your code here. Print output to STDOUT. */
        int aLen = A.length();
        int bLen = B.length();
        int total = aLen+bLen;
        char aFirst = A.charAt(0);
        char bFirst = B.charAt(0);
        int aAscii = (int) aFirst;
        int bAscii = (int) bFirst;
        String isLexichrographical = aAscii > bAscii ? "Yes": "No";
        System.out.println(total);
        System.out.println(isLexichrographical);
        System.out.println(capitalize(A)+" "+capitalize(B));

    }
}




