package tcs.stack;
import java.util.*;
public class pushBootmStack {

   static void insetBottom(Stack<Integer>s,int x)
   {
    if(s.isEmpty())
    {
        s.push(x);
        return;
    }

    //remove top
    int top=s.pop();
    insetBottom(s,x);
    
    s.push(top);
   }
    public static void main(String[]args)
    {
        Stack<Integer>s=new Stack<>();
          s.push(1);
        s.push(2);
        s.push(3);

        insetBottom(s, 10);

    }
}
