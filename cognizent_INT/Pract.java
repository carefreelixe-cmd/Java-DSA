import java.util.Scanner;

public class Pract {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter Number: ");
        int num = Integer.parseInt(scanner.nextLine());
        int count = 0;
        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                count++;
            }
        }
        System.out.println(count == 2 ? num + " is a prime number" : num + " is not a prime number");
    }
}
