package tcs.string;

public class reverssWord {

    public static String reverseWord(String s)
    {
        String[] words = s.split(" ");
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < words.length; i++)
        {
            String word = words[i];

            StringBuilder sb = new StringBuilder(word);
            result.append(sb.reverse());

            if (i != words.length - 1)   // avoid extra space
            {
                result.append(" ");
            }
        }

        return result.toString();
    }

    public static void main(String[] args) {
        String str = "I love Java";
        System.out.println(reverseWord(str));
    }
}
