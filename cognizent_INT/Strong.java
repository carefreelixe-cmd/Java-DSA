public class Strong {
    public static void main(String[] args) {
        int num = 145;
        int temp = num;
        int sum = 0;
        int rem = 0;
        while (temp > 0) {
            rem = temp % 10;
            int fact = 1;
            for (int i = 1; i <= rem; i++) {
                fact *= i;
            }
            sum += fact;
            temp /= 10;
        }
        System.out.println(sum == num ? "This is a Strong number" : "This is not a Strong number");
    }
}
