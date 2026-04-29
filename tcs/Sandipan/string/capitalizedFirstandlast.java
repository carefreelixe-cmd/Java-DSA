package tcs.string;

public class capitalizedFirstandlast {
    public static String []capiTalizedFirstAndLast(String []s)

    {
        for(int i=0;i<s.length;i++)
        {
            StringBuilder sb =new StringBuilder(s[i]);
            
int lastIndex=sb.length()-1;
//capitalize the first character

sb.setCharAt(0,Character.toUpperCase(sb.charAt(0)));
sb.setCharAt(lastIndex,Character.toUpperCase(sb.charAt(lastIndex)));

s[i]=sb.toString();





        }

        return s;
        
    }
}
