import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {



    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int N = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");
        String wierd = "Weird";
        String notWierd = "Not Weird";
        if(N%2 == 0) {
            if(N>=2 && N<=5)
                System.out.println(notWierd);
            else if(N>=6 && N<=20)
                System.out.println(wierd);
            else 
                System.out.println(notWierd);
        } else {
            System.out.println(wierd);
        }

        scanner.close();
    }
}

