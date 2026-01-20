package Cognizant.Sandipan;

public class vowelsinString {
    public static void countVowels(String[]arr)
    {

        int count=0;
        for(int i=0;i<arr.length;i++)
        {
            if(arr[i].toLowerCase().contains("a") || arr[i].toLowerCase().contains("e") || arr[i].toLowerCase().contains("i") || arr[i].toLowerCase().contains("o") || arr[i].toLowerCase().contains("u"))
            {
                count++;
            }
        }
        System.out.println("Total number of vowels in the strings: " + count);
    }

    public static void main(String[] args) {
        String[] arr={"Sandipan","Rnt","Ankt","Sourv","Arpt"};
        countVowels(arr);
    }
}
