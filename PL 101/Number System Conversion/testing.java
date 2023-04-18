import java.util.Scanner;

public class testing {
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        System.out.print("Enter a number base[2-16]: ");
        String binary = scanner.nextLine();

        System.out.print("Base: ");
        int fromBase = scanner.nextInt();

        System.out.print("To base: ");
        int toBase = scanner.nextInt();

        System.out.println(convertNumberSystem(binary, fromBase, toBase));

    }

    public static String convertNumberSystem(String number, int fromBase, int toBase) {
        // Split the number into integer and fractional parts
        String[] parts = number.split("\\.");
        String integerPart = parts[0];
        String fractionalPart = parts.length > 1 ? parts[1] : "";

        // Convert the integer part to decimal first
        int decimalIntegerPart = Integer.parseInt(integerPart, fromBase);

        // Convert the decimal integer part to the target base
        String resultIntegerPart = Integer.toString(decimalIntegerPart, toBase);

        // Convert the fractional part to decimal if it exists
        String resultFractionalPart = "";
        if (!fractionalPart.isEmpty()) {
            double decimalFractionalPart = 0;
            for (int i = 0; i < fractionalPart.length(); i++) {
                int digit = Character.digit(fractionalPart.charAt(i), fromBase);
                decimalFractionalPart += (double) digit / Math.pow(fromBase, i + 1);
            }
            resultFractionalPart = convertFractionalPart(decimalFractionalPart, toBase);
        }

        // Combine the integer and fractional parts to form the final result
        String result = resultIntegerPart;
        if (!resultFractionalPart.isEmpty()) {
            result += "." + resultFractionalPart;
        }

        return result;
    }

    private static String convertFractionalPart(double decimalFractionalPart, int toBase) {
        StringBuilder result = new StringBuilder();
        while (decimalFractionalPart > 0) {
            decimalFractionalPart *= toBase;
            int digit = (int) decimalFractionalPart;
            result.append(Character.forDigit(digit, toBase));
            decimalFractionalPart -= digit;
        }
        return result.toString();
    }
}
