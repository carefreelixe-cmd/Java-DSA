public class PerfectNum {
    public static void main(String[] args) {
        int num = 28;
        int temp = num;
        int sum = 0;
        for (int i = 1; i < num; i++) {
            if (temp % i == 0) {
                sum += i;
            }
        }
        System.out.println(sum == num ? "This is a Perfect number" : "This is not a Perfect number");
    }
}
