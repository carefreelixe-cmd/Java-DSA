package tcs.string;

public class NonRepeatingCharacter {

    public static char nonRepatingCharactr(String s) {

        for (int i = 0; i < s.length(); i++) {

            int count = 0;

            for (int j = 0; j < s.length(); j++) {

                if (s.charAt(i) == s.charAt(j)) {
                    count++;
                }
            }

            if (count == 1) {
                return s.charAt(i);
            }
        }

        return '\0';  // if no non-repeating character
    }

    public static void main(String[] args) {

        String str = "aabbcdd";

        char result = nonRepatingCharactr(str);

        if (result != '\0')
            System.out.println("First Non-Repeating Character: " + result);
        else
            System.out.println("No Non-Repeating Character Found");
    }
}
