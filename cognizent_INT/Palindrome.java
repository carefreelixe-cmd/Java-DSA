public class Palindrome {
    public static void main(String[] args) {
        int num = 12271;
        int temp = num;
        int rev = 0;
        while (temp > 0) {
            rev = rev * 10 + temp % 10;
            temp /= 10;
        }
        System.out.println(num == rev ? "The number is palindrome." : "The number is not palindrome.");
    }
}
