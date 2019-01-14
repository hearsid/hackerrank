import java.util.*;
class Solution{
	
	public static void main(String []argh)
	{
		Scanner sc = new Scanner(System.in);
    while (sc.hasNext()) {
     String input=sc.next();
     Stack<Character> st = new Stack<>();
     for (int i = 0; i < input.length(); i++) {
        if (!st.isEmpty()) {
            switch(input.charAt(i)) {
                case '}' : if (st.peek() == '{') {
                    st.pop();
                } break;
                case ']' : if (st.peek() == '[') {
                    st.pop();
                } break;
                case ')' : if (st.peek() == '(') {
                    st.pop();
                } break;
                default: st.push(input.charAt(i));
          }
        } else {
            st.push(input.charAt(i));
        } 
     }
     System.out.println(st.isEmpty());
  }
		
	}
}





