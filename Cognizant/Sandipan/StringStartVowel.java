package Cognizant.Sandipan;

public class StringStartVowel {
    //Find how many strings start with a vowel


    public static void countStringWithVowel(String[]arr)
    {
        int count=0;
        for(int i=0;i<arr.length;i++)
        {
            if(arr[i].toLowerCase().startsWith("a") || arr[i].toLowerCase().startsWith("e") || arr[i].toLowerCase().startsWith("i") || arr[i].toLowerCase().startsWith("o") || arr[i].toLowerCase().startsWith("u"))
            {
                count++;
            }

        }

        //count how many vowels

        System.out.println("Total number of strings starting with a vowel: " + count);
    }

    public static void countTotalVowels(String[] arr) {
        int count = 0;
      for(int i=0;i<arr.length;i++)
      {
        String str=arr[i].toLowerCase();
        for(int j=0;j<str.length();j++){
            char ch=str.charAt(j);
            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
            {
                count++;
            }
        }
      }
        System.out.println("Total number of vowels: " + count);
    }

    public static void main(String[] args) {
        String[] arr={"Sandipan","Rnt","Ankt","Sourv","Arpt"};
        countStringWithVowel(arr);
        countTotalVowels(arr);
    }
}
