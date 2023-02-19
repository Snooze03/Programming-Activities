import java.util.Scanner;

// To Do:
// [x] Menu
// [x] Binary to other 
// [x] Decimal to other 
// [x] Octal to other 
// [x] Hexa to other 
// [x] Input Validation
// [ ] Clean code
class NumberSystemConverter {
    public static Scanner input = new Scanner(System.in);


    /*========================== MAIN FUNCTION ====================== */
    public static void main(String[] args){
        MainMenu();
    }
    /*================================================================ */


    /*========================== MAIN MENU =========================== */
    private static void MainMenu(){
        CLS();

        System.out.println("==========|| Number System Converter ||==========\n");
        System.out.println("\t\t[1] Binary");
        System.out.println("\t\t[2] Decimal");
        System.out.println("\t\t[3] Octal");
        System.out.println("\t\t[4] Hexadecimal");
        System.out.println("\t\t[5] Exit\n");
        System.out.println("=================================================");
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
                HexaConverter();
                break;
            case 5:
                System.exit(0);
                break;
        }
    }
    /*================================================================ */


    /*========================== CONVERTERS ========================== */
    private static void BinaryConverter(){
        CLS();

        System.out.println("==========|| BINARY ||==========\n");

        // Get binary number input from user
        System.out.print("Enter Binary Number: ");
        String binary = input.nextLine();

        // checks if input is a valid binary 
        while (!isValidBinary(binary)){
            System.out.print("Invalid Binary Number. Please try again: ");
            binary = input.nextLine();
        }

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
        System.out.print("Decimal: " + decimalIntegral);
        if (decimalFractional.length() > 0) System.out.print("." + decimalFractional.toString()); 
        System.out.println();
        
        System.out.print("Octal: " + octalIntegral);
        if (octalFractional.length() > 0) System.out.print("." + octalFractional.toString());
        System.out.println();

        System.out.print("Hexadecimal: " + hexadecimalIntegral);
        if (hexadecimalFractional.length() > 0) System.out.print("." + hexadecimalFractional.toString());
        System.out.println();

        menu(1);
    }

    private static void DecimalConverter(){
        CLS();

        System.out.println("==========|| DECIMAL ||==========\n");

        // Get decimal number input from user
        System.out.print("Enter Decimal Number: ");
        String decimal = input.nextLine();

        while (!isValidDecimal(decimal)){
            System.out.print("Invalid Decimal Number. Please try again: ");
            decimal = input.nextLine();
        }

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

        menu(2);
    }

    private static void OctalConverter(){
        CLS();

        System.out.println("==========|| OCTAL ||==========\n");

        // Get octal number input from user
        System.out.print("Enter Octal Number: ");
        String octal = input.nextLine();

        while (!isValidOctal(octal)){
            System.out.print("Invalid Octal Number. Please try again: ");
            octal = input.nextLine();
        }

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

        menu(3);
    }
    
    private static void HexaConverter(){
        CLS();

        System.out.println("==========|| HEXADECIMAL ||==========\n");

        // Get hexadecimal number input from user
        System.out.print("Enter Hexadecimal Number: ");
        String hexadecimal = input.nextLine();

        while (!isValidHexadecimal(hexadecimal)){
            System.out.print("Invalid Hexadecimal Number. Please try again: ");
            hexadecimal = input.nextLine();
        }

        // Split the hexadecimal number into integral and fractional parts
        String[] parts = hexadecimal.split("\\.");
        String integralPart = parts[0];
        String fractionalPart = "";

        if (parts.length > 1) fractionalPart = parts[1];

        // Convert the integral part to binary, octal, and decimal
        int integral = Integer.parseInt(integralPart, 16);
        String binaryIntegral = Integer.toBinaryString(integral);
        String octalIntegral = Integer.toOctalString(integral);
        String decimalIntegral = Integer.toString(integral);

        // Convert the fractional part to binary, octal, and decimal
        StringBuilder binaryFractional = new StringBuilder();
        StringBuilder octalFractional = new StringBuilder();
        double decimalFractional = 0;

        if (!fractionalPart.isEmpty()) {
            for (char c : fractionalPart.toCharArray()) {
                int hexDigit = Integer.parseInt(String.valueOf(c), 16);
                binaryFractional.append(String.format("%04d", Integer.parseInt(Integer.toBinaryString(hexDigit))));
                octalFractional.append(Integer.toOctalString(hexDigit));
                decimalFractional += hexDigit / 16.0;
                decimalFractional /= 16.0;
            }
        }

        // Output the results
        System.out.print("Binary: " + binaryIntegral);
        if (binaryFractional.length() > 0) System.out.print("." + binaryFractional.toString());
        System.out.println();

        System.out.print("Octal: " + octalIntegral);
        if (octalFractional.length() > 0) System.out.print("." + octalFractional.toString());
        System.out.println();

        System.out.print("Decimal: " + decimalIntegral);
        if (decimalFractional > 0) System.out.printf("%.15f", (integral + decimalFractional));
        System.out.println();
    
        menu(4);
    }
    /*================================================================ */


    /*====================== Validators ============================== */
    private static boolean isValidBinary(String input) {
        // Check if the input is a valid binary number without a fractional part
        boolean IP = input.matches("^[01]+$");

        // Check if the input is a valid binary number with a fractional part
        boolean FP = input.matches("^[01]+(\\.[01]+)?$");

        // Return true if the input is a valid binary 
        return IP || FP;
    }

    private static boolean isValidDecimal(String input) {
        boolean IP = input.matches("^\\d+$");
        boolean FP = input.matches("^\\d+(\\.\\d+)?$");

        return IP || FP;
    }

    private static boolean isValidOctal(String input) {
        boolean IP = input.matches("^[0-7]+$");
        boolean FP = input.matches("^[0-7]+(\\.[0-7]+)?$");

        return IP || FP;
    }

    private static boolean isValidHexadecimal(String input) {
        boolean IP = input.matches("^[0-9a-fA-F]+$");
        boolean FP = input.matches("^[0-9a-fA-F]+(\\.[0-9a-fA-F]+)?$");

        return IP || FP;
    }


    /*================================================================ */
    private static void menu(int op){
        System.out.println("\n==========|| Options ||==========\n");
        System.out.println("\t[1] Convert again");
        System.out.println("\t[2] Main Menu");
        System.out.println("\t[3] Exit");
        System.out.println("\n=================================\n");
        System.out.print("Option: ");

        // Checks if input is int or not
        while(!input.hasNextInt()){
            System.out.println("INVALID INPUT! Please enter an INTEGER!");
            input.next();
            System.out.print("Option: ");
        }

        int option = input.nextInt();
        input.nextLine();

        switch(option){
            case 1:
                switch(op){
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
                        HexaConverter();
                        break;
                }
                break;
            case 2:
                MainMenu();
                break;
            case 3:
                System.exit(0);
        }
    } 
    /*=============================================================== */


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