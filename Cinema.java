package CinemaProject;
//import java.text.DecimalFormat;
import java.util.Scanner;

public class Cinema {
    public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
    System.out.println("Enter the number of rows:");
    int x = sc.nextInt();
    System.out.println("Enter the number of seats in each row:");
    int y = sc.nextInt();
    int menu;
    char[][] cinema = new char[x][y];
    int row = -1;
    int seat = -1;
    int price;
    int NumberOfTickets = 0;
    int Income = 0;
    boolean TakenSeats;

    do {
        menu = Menu(sc);
        switch (menu) {
            case 1: ShowTheSeats(y, x, cinema, row, seat); break;
            case 2: {
                do {
                        TakenSeats = false;
                        int rowcoppy = row;
                        int seatcoppy = seat;

                        System.out.println("Enter a row number:");
                        row = sc.nextInt();
                        System.out.println("Enter a seat number in that row:");
                        seat = sc.nextInt();

                        if (row > x || seat > y) {
                        System.out.println("Wrong input!");
                        TakenSeats = true;
                        }

                        else if (cinema[row - 1][seat - 1] == 'B' || row == rowcoppy && seat == seatcoppy) {
                            System.out.println("That ticket has already been purchased!");
                            TakenSeats = true;
                            System.out.println();
                        }

                } while (TakenSeats);

                System.out.println();

                price = TicketPrise(x,y,row);
                System.out.println("$" + price);
                System.out.println();
                Income += price;
                NumberOfTickets += 1;
            } break;
            case 3: Statistics(NumberOfTickets, x, y, Income); break;
            case 0: break;
            default: Menu(sc);
        }
    } while (menu != 0);
}

    public static int Menu(Scanner sc) {
        System.out.println("""
                1. Show the seats
                2. Buy a ticket
                3. Statistics
                0. Exit""");
        return sc.nextInt();
    }

    public static void ShowTheSeats(int y, int x, char[][]cinema, int row , int seat ) {

        System.out.print(" ");
        System.out.println("Cinema:");
        System.out.println();

        System.out.print(" ");
        for (int i = 1; i < y + 1; i++) {
            System.out.print(" " + i);
        }
        System.out.println();

        for (int i = 0; i < x; i++) {
            System.out.print(i+1 + " ");
            for (int k = 0; k < y; k++) {
                if (cinema[i][k] != 'B') {
                    cinema[i][k] = 'S';
                }
                if (seat != -1 && row != -1) {
                    cinema[row-1][seat-1] = 'B';
                }
                System.out.print(cinema[i][k] + " ");
            }
            System.out.println();
        }
        System.out.println();
    }

    public static Integer TicketPrise (int x, int y, int row) {
        System.out.print("Ticket price:");
        if(x*y<60) {
            return 10;
        }
        else {
            if (row<=x/2) {
                return 10;
            }
            else {
                return 8;
            }
        }
    }

    public static void Statistics( int NumberOfTickets, int x, int y, int Income) {

        System.out.println("Number of purchased tickets: " + NumberOfTickets);
        float Percentage = (float) NumberOfTickets /(x*y) * 100;
        //DecimalFormat df = new DecimalFormat("###.##");
        //String RoundedPercentge = df.format(Percentage);
        System.out.print("Percentage: ");
        System.out.printf("%.2f", Percentage);
        System.out.println("%");
        System.out.println("Current income: $" + Income);
        int TotalIncome;
        if (x*y<60) {
            TotalIncome = x*y*10;
        }
        else {
            TotalIncome = ((x - x/2) * y * 8) + ((x/2)*y *10);
        }
        System.out.println("Total income: $" + TotalIncome);
        System.out.println();

    }
}



