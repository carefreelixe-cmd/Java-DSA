public class Armstrong {
    public static void main(String[] args) {
        int num = 153;
        int temp = num;
        int rem;
        int sum = 0;
        while (temp > 0) {
            rem = temp % 10;
            sum += (int) Math.pow(rem, 3);
            temp /= 10;
        }
        System.out.println(sum == num ? "The number is Armstrong" : "This is not Armstrong");
    }
}
