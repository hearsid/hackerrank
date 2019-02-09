    import java.util.*;
    public class test {
        public static void main(String[] args) {
            Scanner in = new Scanner(System.in);
            Deque<Integer> deque = new ArrayDeque<Integer>();
            Set<Integer> st= new HashSet<Integer>();
            int n = in.nextInt();
            int m = in.nextInt();
            int unique =0;

            for (int i = 0; i < n; i++) {
                int num = in.nextInt();
                
                deque.add(num);
                st.add(num);
                
                if(deque.size() == m) {
                    if(st.size() > unique) unique = st.size();
                    
                    int first = deque.remove();
                    if(!deque.contains(first)) st.remove(first);
                    
                }
               
            }
            
            System.out.println(unique);
        }
    }




