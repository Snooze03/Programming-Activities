import java.util.Scanner;

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
                BinaryPrompt();
                break;
            case 2:
                DecimalPrompt();
                break;
            case 3:
                OctalPrompt();
                break;
            case 4:
                HexaPrompt();
                break;
            case 5:
                System.exit(0);
                break;
        }
    }
    /*================================================================ */


    /*========================== PROMPTS ============================= */
    private static void BinaryPrompt(){
        CLS();

        System.out.println("==========|| BINARY ||==========\n");
        System.out.print("Enter a binary number: ");
        String binary = input.nextLine();

        // Validate input
        while(!isValidBinary(binary)){
            System.out.print("Invalid binary number. Enter a binary number: ");
            binary = input.nextLine();
        }

        System.out.println("Decimal: " + convertNumberSystem(binary, 2, 10));
        System.out.println("Octal: " + convertNumberSystem(binary, 2, 8));
        System.out.println("Hexadecimal: " + convertNumberSystem(binary, 2, 16).toUpperCase());

        menu(1);
    } 

    private static void DecimalPrompt(){
        CLS();

        System.out.println("==========|| DECIMAL ||==========\n");
        System.out.print("Enter a decimal number: ");
        String decimal = input.nextLine();

        while(!isValidDecimal(decimal)){
            System.out.print("Invalid decimal number. Enter a decimal number: ");
            decimal = input.nextLine();
        }

        System.out.println("Binary: " + convertNumberSystem(decimal, 10, 2));
        System.out.println("Octal: " + convertNumberSystem(decimal, 10, 8));
        System.out.println("Hexadecimal: " + convertNumberSystem(decimal, 10, 16).toUpperCase());

        menu(2);
    } 

    private static void OctalPrompt(){
        CLS();

        System.out.println("==========|| OCTAL ||==========\n");
        System.out.print("Enter a octal number: ");
        String octal = input.nextLine();

        while(!isValidOctal(octal)){
            System.out.print("Invalid octal number. Enter a octal number: ");
            octal = input.nextLine();
        }

        System.out.println("Binary: " + convertNumberSystem(octal, 8, 2));
        System.out.println("Decimal: " + convertNumberSystem(octal, 8, 10));
        System.out.println("Hexadecimal: " + convertNumberSystem(octal, 8, 16).toUpperCase());
    
        menu(3);
    } 

    private static void HexaPrompt(){
        CLS();

        System.out.println("==========|| HEXADECIMAL ||==========\n");
        System.out.print("Enter a hexadecimal number: ");
        String hexa = input.nextLine();

        while(!isValidHexadecimal(hexa)){
            System.out.print("Invalid hexadecimal number. Enter a hexadecimal number: ");
            hexa = input.nextLine();
        }

        System.out.println("Binary: " + convertNumberSystem(hexa, 16, 2));
        System.out.println("Decimal: " + convertNumberSystem(hexa, 16, 10));
        System.out.println("Octal: " + convertNumberSystem(hexa, 16, 8));
    
        menu(4);
    } 
    /*================================================================ */


    /*========================== CONVERTERS ========================== */
    private static String convertNumberSystem(String number, int fromBase, int toBase) {
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
        if (!resultFractionalPart.isEmpty()) result += "." + resultFractionalPart;

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
                        BinaryPrompt();
                        break;
                    case 2:
                        DecimalPrompt();
                        break;
                    case 3:
                        OctalPrompt();
                        break;    
                    case 4: 
                        HexaPrompt();
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
    /*=============================================================== */
    }
}