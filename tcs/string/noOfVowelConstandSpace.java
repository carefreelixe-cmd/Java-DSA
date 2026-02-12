package tcs.string;

public class noOfVowelConstandSpace {

    public static void noOfVowelandConstSpace(String str1) {

        int vowels = 0;
        int consonants = 0;
        int spaces = 0;

        str1 = str1.toLowerCase();  // convert to lowercase for easy comparison

        for (int i = 0; i < str1.length(); i++) {

            char ch = str1.charAt(i);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') {
                vowels++;
            }
            else if (ch >= 'a' && ch <= 'z') {
                consonants++;
            }
            else if (ch == ' ') {
                spaces++;
            }
        }

        System.out.println("Vowels: " + vowels);
        System.out.println("Consonants: " + consonants);
        System.out.println("Spaces: " + spaces);
    }

    public static void main(String[] args) {
        String str = "Hello World";
        noOfVowelandConstSpace(str);
    }
}
