public class SumDigit {
    public static void main(String[] args) {
        int num = 1234;
        int temp = num;
        int sum = 0;
        while (temp > 0) {
            sum += temp % 10;
            temp /= 10;
        }
        System.out.println(sum);
    }
}
