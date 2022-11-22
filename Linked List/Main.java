import java.util.Scanner;

public class Main {
    private static LinkedList linkedList = new LinkedList();
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        clearScreen();
        genLinkedList();
        MainMenu();
    } 

    private static void MainMenu(){
        System.out.println("\n\n+-------------------------+\n\n\tMain Menu\n\n\t1. Insert\n\t2. Delete\n\t3. Display\n\t4. Exit\n\n+-------------------------+");

        System.out.print("Option: ");
        int option = Integer.parseInt(scanner.nextLine());

        switch(option){
            case 1:
                clearScreen();
                InsertMenu();
                break;
            case 2:
                DeleteMenu();
                break;
            case 3:
                clearScreen();
                DisplayLinkedList();
                MainMenu();
                break;
            case 4:
                System.exit(0);
                break;
        }
    }

    private static void InsertMenu(){
        System.out.println("+-------------------------+\n\n\tInsert at...\n\n\t1. Start\n\t2. End\n\t3. Index\n\t4. Back\n\n+-------------------------+");

        System.out.print("Option: ");
        int option = Integer.parseInt(scanner.nextLine());

        switch(option){
            case 1:
                {
                    System.out.print("Data: ");
                    int data = Integer.parseInt(scanner.nextLine());
                    linkedList.insertAtStart(data);

                    clearScreen();
                    System.out.printf("%s has been inserted\n", data);
                    InsertMenu();

                    break;
                }
            case 2:
                {
                    System.out.print("Data: ");
                    int data = Integer.parseInt(scanner.nextLine());
                    linkedList.insert(data);

                    clearScreen();
                    System.out.printf("%s has been inserted\n", data);
                    InsertMenu();

                    break;
                }
            case 3:
                {
                    int index, data;

                    System.out.print("Index: ");
                    index = Integer.parseInt(scanner.nextLine());

                    System.out.print("Data: ");
                    data = Integer.parseInt(scanner.nextLine());

                    linkedList.insertAt(index, data);

                    clearScreen();
                    System.out.printf("%s has been inserted\n", data);
                    InsertMenu();

                    break;
                }
            case 4:
                clearScreen();
                MainMenu();
                break;
        }
    }

    private static void DeleteMenu(){
        DisplayLinkedList();

        System.out.print("\nIndex: ");
        int index = Integer.parseInt(scanner.nextLine());

        linkedList.delete(index);

        clearScreen();

        System.out.printf("value at %s has been deleted", index);

        MainMenu();
    }

    private static void DisplayLinkedList(){
        clearScreen();
        System.out.println("Displaying Linked List\n");
        linkedList.display();
    }


    private static void genLinkedList(){
        for (int i = 0; i < 3; i++){
            linkedList.insert(i+3);
        }
    }

    private static void clearScreen() {
        System.out.print("\033[H\033[2J");
        System.out.flush();
    }
}
