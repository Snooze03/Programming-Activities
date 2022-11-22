import java.util.*;
import java.util.concurrent.ArrayBlockingQueue;

class Main{
    private static QuickSort qSort = new QuickSort();
    private static Scanner scanner = new Scanner(System.in);

    public static void main(String[] args){

        // int size = data.length;

        // // call quicksort() on array data
        // qSort.quickSort(data, 0, size - 1);

        // System.out.println("Sorted Array in Ascending Order ");
        // System.out.println(Arrays.toString(data));
        clearScreen();
        MainMenu();

    }

    private static void MainMenu(){
        System.out.println("+--------------------------------+\n\n\tSorting Algorithm\n\n\t\n\t1. Quick Sort\n\t2. Exit\n\n+--------------------------------+");

        System.out.print("Option: ");
        int option = Integer.parseInt(scanner.nextLine());

        switch(option){
            case 1:
                clearScreen();

                // Gen array with random elements
                int[] arr = GenArray();
                
                clearScreen();
                System.out.println("Unsorted Array:");
                DisplayArray(arr);

                // Sort arr
                qSort.quickSort(arr, 0, (arr.length - 1));

                System.out.println("\nSorted Array:");
                DisplayArray(arr);
                break;
            case 2:
                System.exit(1);
                break;
        }
    }

    private static int[] GenArray(){
        Random rd = new Random();
        int arrLen;

        System.out.print("Enter Array Length: ");
        arrLen = Integer.parseInt(scanner.nextLine());

        int[] arr = new int[arrLen];

        for(int i = 0; i < arrLen; i++) arr[i] = rd.nextInt(0, 100);

        return arr;
    }

    private static void DisplayArray(int[] arr){
        for (int i : arr) System.out.print(i + " ");
    }

    private static void clearScreen() {
        System.out.print("\033[H\033[2J");
        System.out.flush();
    }
}