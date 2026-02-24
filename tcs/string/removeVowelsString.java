package tcs.string;
import java.util.*;

public class removeVowelsString {

    public static void removeVowelString(String str) {

        str = str.toLowerCase();

        // Step 1: Create HashSet for result
        HashSet<Character> set = new HashSet<>();

        for (int i = 0; i < str.length(); i++) {

            char ch = str.charAt(i);

            if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u') {
                set.add(ch);
            }
        }

        System.out.println(set);
    }

    public static void main(String[] args) {
        removeVowelString("Hello World");
    }
}
