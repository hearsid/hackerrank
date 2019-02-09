import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String noOfElements = in.nextLine();
        String elementString = in.nextLine();
        String[] elementsAsString = elementString.split(" ");
        String reversedString = "" ;
        int i = 1;
        for(String single: elementsAsString) {
          reversedString = reversedString + (i!=1?" ":"") + elementsAsString[elementsAsString.length - i ];
          i+=1;
        }
        System.out.println(reversedString);
    }
}

