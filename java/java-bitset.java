import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static BitSet[] performOperation(String op, BitSet bs1, BitSet bs2, int b1, int b2 ) throws Exception{
        switch (op) {
            case "AND":
                bs1.and(bs2);
                break;

            case "SET":
                if(b1 == 1) {
                    bs1.set(b2);
                } else {
                    bs2.set(b2);
                }
                break;

            case "FLIP":
                if(b1 == 1) {
                    bs1.flip(b2);
                } else {
                    bs2.flip(b1);
                }
                break;

            case "OR":
                bs1.or(bs2);
                break;

            case "XOR":
                bs1.xor(bs2);
                break;

            default:
                throw new Exception("Operation not in the list");
        };
        BitSet[] result = new BitSet[2];
        result[0] = bs1;
        result[1] = bs2;
        return result;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int bitsetSize = sc.nextInt();
        int ops = sc.nextInt();
        BitSet b1 = new BitSet(bitsetSize);
        BitSet b2 = new BitSet(bitsetSize);
        b1.set(0,bitsetSize, false);
        b2.set(0,bitsetSize, false);
        BitSet[] result = new BitSet[2];
        sc.nextLine();
        for(int i = 0; i< ops; i++ ) {
            String in = sc.nextLine();
            String ins[] = in.split(" ");
            String op = ins[0];
            int firstDigit = Integer.parseInt(ins[1]);
            int secondDigit = Integer.parseInt(ins[2]);
            try {
                switch(firstDigit){
                    case 1:
                        result = performOperation(op, b1, b2, firstDigit, secondDigit);
                        System.out.print(result[0].cardinality());
                        System.out.println(b2.cardinality());
                        break;

                    case 2:
                        result = performOperation(op, b2, b1, firstDigit, secondDigit);
                        System.out.print(b1.cardinality());
                        System.out.println(result[0].cardinality());
                        break;

                    default:
                        break;
                }

            } catch (Exception e) {
                System.out.println(e);
            }
        }
        sc.close();
    }
}
