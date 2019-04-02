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
        BigInteger n = scanner.nextBigInteger();

        scanner.close();
        String prime = "prime";
        String notPrime = "not prime";
        System.out.println(n.isProbablePrime(1)? prime: notPrime);
        
    }
}

