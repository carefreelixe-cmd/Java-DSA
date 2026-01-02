package Sandipan.String;
import java.util.*;
public class Direction {
    public static int TotalDirection(String str)
    {
        int x=0;
        int y=0;
        for(int i=0;i<str.length();i++){
            char ch=str.charAt(i);
            if(ch=='N')
            {
                y++;
            }
            else if (ch=='S')
            {
                y--;
            }
            else if (ch=='E')
            {
                x++;
            }
            else if (ch=='W')
            {
                x--;
            }
        }
        return (int)Math.sqrt(x*x + y*y);



    }

    public static void main(String[] args)
    {
        String str="NENWS";
        System.out.println("Final Position is: ("+TotalDirection(str)+")");
    }
}
