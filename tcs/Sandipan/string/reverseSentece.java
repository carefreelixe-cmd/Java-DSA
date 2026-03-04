package tcs.string;

public class reverseSentece {
    public static String reverseSenetnce(String s)

    {
        String [] charArray=s.split(" ");
        StringBuilder result=new StringBuilder();
    
        for(int i=charArray.length-1;i>=0;i--)
        {
            StringBuilder sb=new StringBuilder(charArray[i]);

            result.append(sb).append(" ");
            

        }

        return result.toString().trim();
    }

  

    //trim used to remove extra space

 
}
