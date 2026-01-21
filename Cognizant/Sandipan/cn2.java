package Cognizant.Sandipan;

public class cn2 {
    public static void SumOfAlphabet(String str)
    {
       
int sum=0;
        for(int i=0;i<str.length();i++)
{
      
      sum+=str.charAt(i)-97+1;
        System.out.println("The sum of alphabet is "+sum);
}        
    }


    public static void main(String[] args) {
        String str="abc";
        SumOfAlphabet(str);
    }
}
