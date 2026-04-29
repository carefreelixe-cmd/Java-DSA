package tcs.pyq;

public class binary {

    public static int DecimalToBinary(String number) {

        // Step 1: String decimal → int
        int decimal = Integer.parseInt(number);

        // Step 2: Decimal → binary
        String binary = Integer.toBinaryString(decimal);

        // Step 3: Flip bits
        StringBuilder result = new StringBuilder(binary);
        for (int i = 0; i < result.length(); i++) {
            if (result.charAt(i) == '0') {
                result.setCharAt(i, '1');
            } else { // must be else
                result.setCharAt(i, '0');
            }
        }

        // Step 4: Binary → decimal
        int finalDecimal = Integer.parseInt(result.toString(), 2);

        return finalDecimal;
    }

    public static void main(String[] args) {
        System.out.println(DecimalToBinary("10"));
    }
}
