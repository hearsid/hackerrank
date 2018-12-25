import java.io.*;
import java.util.*;
import java.math.*;
public class Solution {

    public static void main(String[] args) {
        BigInteger bi;
        BigInteger bi2;
        Scanner sc = new Scanner(System.in);
         bi = sc.nextBigInteger();
         bi2 = sc.nextBigInteger();
        System.out.println(bi.add(bi2));
        System.out.println(bi.multiply(bi2));
    }
}
