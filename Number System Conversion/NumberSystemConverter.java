import java.util.Scanner;

// To Do:
// [x] Menu
// [x] Binary to other 
// [x] Decimal to other 
// [x] Octal to other 
// [ ] Hexa to other 
// [ ] Input Validation
class NumberSystemConverter {
    public static Scanner input = new Scanner(System.in);

    public static void main(String[] args){
        menu();
    }

    private static void menu(){
        System.out.println("==========|| Number System Converter ||==========\n");
        System.out.println("\t\t1. Binary");
        System.out.println("\t\t2. Decimal");
        System.out.println("\t\t3. Octal");
        System.out.println("\t\t4. Hexadecimal");
        System.out.println("\t\t5. Exit\n");
        System.out.println("==================================================");
        System.out.print("Option: ");

        // Checks if input is int or not
        while(!input.hasNextInt()){
            System.out.println("INVALID INPUT! Please enter an INTEGER!");
            input.next();
            System.out.print("Option: ");
        }

        int option = input.nextInt();

        CLS();
        input.nextLine();

        switch(option){
            case 1:
                BinaryConverter();
                break;
            case 2:
                DecimalConverter();
                break;
            case 3:
                OctalConverter();
                break;
            case 4:
                break;
        }
    }

    private static void BinaryConverter(){
        // Get binary number input from user
        System.out.print("Enter Binary Number: ");
        String binary = input.nextLine();

        // Split the binary number into integral and fractional parts
        String[] parts = binary.split("\\.");
        String integralPart = parts[0];
        String fractionalPart = "";

        if (parts.length > 1) fractionalPart = parts[1];

        // Convert the integral part to octal, decimal, and hexadecimal
        int integral = Integer.parseInt(integralPart, 2);
        String octalIntegral = Integer.toOctalString(integral);
        String decimalIntegral = Integer.toString(integral);
        String hexadecimalIntegral = Integer.toHexString(integral).toUpperCase();

        // Convert the fractional part to octal, decimal, and hexadecimal
        StringBuilder octalFractional = new StringBuilder();
        StringBuilder decimalFractional = new StringBuilder();
        StringBuilder hexadecimalFractional = new StringBuilder();

        if (!fractionalPart.isEmpty()) {
            double fractional = Double.parseDouble("0." + fractionalPart);

            while (fractional > 0) {
                fractional *= 8;
                int octalDigit = (int) fractional;
                octalFractional.append(octalDigit);
                fractional -= octalDigit;

                fractional *= 10;
                int decimalDigit = (int) fractional;
                decimalFractional.append(decimalDigit);
                fractional -= decimalDigit;

                fractional *= 16;
                int hexadecimalDigit = (int) fractional;

                if (hexadecimalDigit < 10) hexadecimalFractional.append(hexadecimalDigit);
                else hexadecimalFractional.append((char) ('A' + hexadecimalDigit - 10));

                fractional -= hexadecimalDigit;
            }
        }

        // Output the results
        System.out.print("Octal: " + octalIntegral);
        if (octalFractional.length() > 0) System.out.print("." + octalFractional.toString());
        System.out.println();

        System.out.print("Decimal: " + decimalIntegral);
        if (decimalFractional.length() > 0) System.out.print("." + decimalFractional.toString()); 
        System.out.println();

        System.out.print("Hexadecimal: " + hexadecimalIntegral);
        if (hexadecimalFractional.length() > 0) System.out.print("." + hexadecimalFractional.toString());
        System.out.println();
    }

    private static void DecimalConverter(){
        // Get decimal number input from user
        System.out.print("Enter Decimal Number: ");
        String decimal = input.nextLine();

        // Split the decimal number into integral and fractional parts
        String[] parts = decimal.split("\\.");
        String integralPart = parts[0];
        String fractionalPart = "";

        if (parts.length > 1) fractionalPart = parts[1];

        // Convert the integral part to binary, octal, and hexadecimal
        int integral = Integer.parseInt(integralPart);
        String binaryIntegral = Integer.toBinaryString(integral);
        String octalIntegral = Integer.toOctalString(integral);
        String hexadecimalIntegral = Integer.toHexString(integral).toUpperCase();

        // Convert the fractional part to binary, octal, and hexadecimal
        StringBuilder binaryFractional = new StringBuilder();
        StringBuilder octalFractional = new StringBuilder();
        StringBuilder hexadecimalFractional = new StringBuilder();

        if (!fractionalPart.isEmpty()) {
            double fractional = Double.parseDouble("0." + fractionalPart);

            while (fractional > 0) {
                fractional *= 2;
                int binaryDigit = (int) fractional;
                binaryFractional.append(binaryDigit);
                fractional -= binaryDigit;

                fractional *= 8;
                int octalDigit = (int) fractional;
                octalFractional.append(octalDigit);
                fractional -= octalDigit;

                fractional *= 16;
                int hexadecimalDigit = (int) fractional;

                if (hexadecimalDigit < 10) hexadecimalFractional.append(hexadecimalDigit);
                else hexadecimalFractional.append((char) ('A' + hexadecimalDigit - 10));

                fractional -= hexadecimalDigit;
            }
        }

        // Output the results
        System.out.print("Binary: " + binaryIntegral);
        if (binaryFractional.length() > 0) System.out.print("." + binaryFractional.toString());
        System.out.println();

        System.out.print("Octal: " + octalIntegral);
        if (octalFractional.length() > 0) System.out.print("." + octalFractional.toString());
        System.out.println();

        System.out.print("Hexadecimal: " + hexadecimalIntegral);
        if (hexadecimalFractional.length() > 0) System.out.print("." + hexadecimalFractional.toString());
        System.out.println();
    }

    private static void OctalConverter(){
        // Get octal number input from user
        System.out.print("Enter Octal Number: ");
        String octal = input.nextLine();

        // Split the octal number into integral and fractional parts
        String[] parts = octal.split("\\.");
        String integralPart = parts[0];
        String fractionalPart = "";

        if (parts.length > 1) fractionalPart = parts[1];

        // Convert the integral part to binary, decimal, and hexadecimal
        int integral = Integer.parseInt(integralPart, 8);
        String binaryIntegral = Integer.toBinaryString(integral);
        String decimalIntegral = Integer.toString(integral);
        String hexadecimalIntegral = Integer.toHexString(integral).toUpperCase();

        // Convert the fractional part to binary, decimal, and hexadecimal
        StringBuilder binaryFractional = new StringBuilder();
        StringBuilder decimalFractional = new StringBuilder();
        StringBuilder hexadecimalFractional = new StringBuilder();

        if (!fractionalPart.isEmpty()) {
            double fractional = Double.parseDouble("0." + fractionalPart);

            while (fractional > 0) {
                fractional *= 2;
                int binaryDigit = (int) fractional;
                binaryFractional.append(binaryDigit);
                fractional -= binaryDigit;

                fractional *= 10;
                int decimalDigit = (int) fractional;
                decimalFractional.append(decimalDigit);
                fractional -= decimalDigit;

                fractional *= 16;
                int hexadecimalDigit = (int) fractional;

                if (hexadecimalDigit < 10) hexadecimalFractional.append(hexadecimalDigit);
                else hexadecimalFractional.append((char) ('A' + hexadecimalDigit - 10));

                fractional -= hexadecimalDigit;
            }
        }

        // Output the results
        System.out.print("Binary: " + binaryIntegral);
        if (binaryFractional.length() > 0)  System.out.print("." + binaryFractional.toString());
        System.out.println();

        System.out.print("Decimal: " + decimalIntegral);
        if (decimalFractional.length() > 0) System.out.print("." + decimalFractional.toString());
        System.out.println();

        System.out.print("Hexadecimal: " + hexadecimalIntegral);
        if (hexadecimalFractional.length() > 0) System.out.print("." + hexadecimalFractional.toString());
        System.out.println();
    }

    private static void CLS(){
        try{
            String operatingSystem = System.getProperty("os.name"); //Check the current operating system
            
            // Windows
            if(operatingSystem.contains("Windows")){
                new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();
            } 
            // Unix 
            else {
                new ProcessBuilder("clear").inheritIO().start().waitFor();
            } 
        }
        catch(Exception e){
            System.out.println(e);
        }
    }
}