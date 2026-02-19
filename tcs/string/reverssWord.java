package tcs.string;

public class reverssWord {
    public static String reverseWord(String s)
    {
        String [] words=s.split(" ");
        StringBuilder result=new StringBuilder();
        for(String word:words)
        {
            StringBuilder sb=new StringBuilder(word);
            result.append(sb.reverse()).append(" ");
        }
        return s;
    }
}
