public class RevNum {
    public static void main(String[] args) {
        int num = 4587;
        int temp = num;
        int rev = 0;
        while (temp > 0) {
            rev = rev * 10 + temp % 10;
            temp /= 10;
        }
        System.out.println(rev);
    }
}
