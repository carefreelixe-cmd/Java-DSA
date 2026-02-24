package tcs.string;

public class calculateFreqString {
    public static int calcuLateFreqString(String []s)

    {
        int count=0;
        for(int i=0;i<s.length;i++)
        {
            for(int j=i+1;j<s.length;j++)
            {
               if(s[i].equals(s[j]))

                    {
                        count ++;
                    }
            }
        }

        return count;
    }
}
