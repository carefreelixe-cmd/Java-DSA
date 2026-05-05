import java.util.Scanner;

public class Basic {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the number : ");
        int n = Integer.parseInt(scanner.nextLine());
        System.out.println(n % 2 == 0 ? "The number is even" : n + " this is a odd number");
    }
}
