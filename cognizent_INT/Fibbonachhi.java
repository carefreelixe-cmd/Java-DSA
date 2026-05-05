import java.util.Scanner;

public class Fibbonachhi {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter Limit: ");
        int num = Integer.parseInt(scanner.nextLine());
        int a = 0, b = 1;
        int c;
        for (int i = 0; i < num; i++) {
            System.out.print(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        System.out.println();
    }
}
