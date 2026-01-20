package Cognizant.Sandipan;
//reverse each string in the array
public class reverseEachString {
    public static void main(String[] args) {
        String[] arr = {"hello", "world", "java"};
        
        for(int i=0;i<arr.length;i++)
        {
            char ch[]=arr[i].toCharArray();
            for(int j=0;j<ch.length/2;j++)
            {
                char temp=ch[j];
                ch[j]=ch[ch.length-1-j];
                ch[ch.length-1-j]=temp;
            }
            arr[i]=String.valueOf(ch);
        }
        
        for(int i=0;i<arr.length;i++)
        {
            System.out.println(arr[i]);
        }
    }
}
