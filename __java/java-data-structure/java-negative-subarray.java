import java.io.*;
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int entries = sc.nextInt();
        int []arr = new int[entries];
        for(int i=0; i< entries; i++) {
            arr[i] = sc.nextInt();
        }
        int totalNegative = 0;
        
        for(int j=0; j<entries; j++) {
            int sum = 0;
            for(int k=j; k<entries; k++) {
                sum = arr[k]+sum;
                if(sum<0) {
                    totalNegative+=1;
                }
            }
        }
        System.out.println(totalNegative);
    }
}
