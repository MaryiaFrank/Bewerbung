package ticractou;

import java.util.Scanner;

public class Tictactou {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        char[][] field = new char[5][9];
        char[][] field_input_only = new char[3][3];
        char[][] field_input_only_turned = new char[3][3];
        String coordinates;
        int turns_counter = 0;
        boolean exception;
        boolean how_many_X;
        boolean how_many_O;
        boolean stop_game;

        printEmptyField(field);
        do {
            do {
                coordinates = inputCoordinates(sc);
                String[] pieces = splitCoordinates(coordinates);

                String xString = pieces[0];
                String yString = pieces[1];

                exception = NumbersException(xString, yString); // only numbers!
                if (!exception)
                    continue;

                int x = Integer.parseInt(pieces[0]);
                int yInput = Integer.parseInt(pieces[1]); // 1-3 doesn't fit into array Field. But we use it later to add coordinates into "field_input_only" array.

                exception = RightNumbers(x, yInput); // only numbers from 1 to 3!
                if (!exception)
                    continue;

                int y = MakeYCorrect(yInput); // make y fit into array "field".

                exception = CheckCellOccupations(field, x, y);
                if (!exception)
                    continue;

                field[x][y] = 'X';
                field_input_only[x - 1][yInput - 1] = 'X'; // add coordinates into "field_input_only".

            } while (!exception);

            PrintField(field);
            turns_counter++;

            how_many_X = X_and_O_input_counter(field_input_only, 'X');
            how_many_O = X_and_O_input_counter(field_input_only, 'O');

            stop_game = Who_wins(how_many_X, how_many_O);
            if (stop_game) {
                break;
            }

            if (!how_many_X && !how_many_O) { //turning "field_input_only".
                for (int k = 0; k < 3; k++) {
                    for (int h = 0; h < 3; h++) {
                        field_input_only_turned[k][h] = field_input_only[Math.abs(h)][Math.abs(k - 2)];
                    }
                }
            }

            how_many_X = X_and_O_input_counter(field_input_only_turned, 'X');
            how_many_O = X_and_O_input_counter(field_input_only_turned, 'Y');
            stop_game = Who_wins(how_many_X, how_many_O);
            if (stop_game) {
                break;
            }

            if(turns_counter < 9) {      // turn of "O"
                do {
                    coordinates = inputCoordinates(sc);
                    String[] pieces = splitCoordinates(coordinates);

                    String xString = pieces[0];
                    String yString = pieces[1];

                    exception = NumbersException(xString, yString); // only numbers!
                    if (!exception)
                        continue;

                    int x = Integer.parseInt(pieces[0]);
                    int yInput = Integer.parseInt(pieces[1]); // 1-3 doesn't fit into array Field. But we use it later to add coordinates into "field_input_only" array.

                    exception = RightNumbers(x, yInput); // only numbers from 1 to 3!
                    if (!exception)
                        continue;

                    int y = MakeYCorrect(yInput); // make y fit into array "field".

                    exception = CheckCellOccupations(field, x, y);
                    if (!exception)
                        continue;

                    field[x][y] = 'O';
                    field_input_only[x - 1][yInput - 1] = 'O'; // add coordinates into "field_input_only".

                } while (!exception);

                PrintField(field);
                turns_counter++;

                how_many_X = X_and_O_input_counter(field_input_only, 'X');
                how_many_O = X_and_O_input_counter(field_input_only, 'O');

                stop_game = Who_wins(how_many_X, how_many_O);
                if (stop_game) {
                    break;
                }

                if (!how_many_X && !how_many_O) { //turning "field_input_only".
                    for (int k = 0; k < 3; k++) {
                        for (int h = 0; h < 3; h++) {
                            field_input_only_turned[k][h] = field_input_only[Math.abs(h)][Math.abs(k - 2)];
                        }
                    }
                }

                how_many_X = X_and_O_input_counter(field_input_only_turned, 'X');
                how_many_O = X_and_O_input_counter(field_input_only_turned, 'Y');
                stop_game = Who_wins(how_many_X, how_many_O);
                if (stop_game) {
                    break;
                }
            }
        } while (turns_counter < 9 || !stop_game);

        if (!how_many_O && !how_many_X) {
            System.out.println("Draw");
        }

    }

    public static Boolean Who_wins(boolean X, boolean O) {
        if (X && !O) {
            System.out.println("X wins");
            return true;
        }
        if (O && !X) {
            System.out.println("O wins");
            return true;
        } else return false;
    }

    public static Boolean X_and_O_input_counter(char[][] field, char x_or_o) {

        int count = 0;

        for (int i = 0; i < 3; i++) {
            if (count == 3) {
                break;
            } else {
                count = 0;
            }

            for (int j = 0; j < 3; j++) {
                if (field[i][j] == x_or_o) {
                    count += 1;
                    if (count == 3) {
                        break;
                    }
                }
            }
        }

        if (field[0][0] == x_or_o && field[1][1] == x_or_o && field[2][2] == x_or_o || //cris-cross check
                field[0][2] == x_or_o && field[1][1] == x_or_o && field[2][0] == x_or_o) {
            count = 3;
        }

        if (count == 3) {
            return true;
        } else return false;
    }

    public static void PrintField(char[][] field) {

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 9; j++) {
                System.out.print(field[i][j]);
            }
            System.out.println();
        }
    }

    static boolean CheckCellOccupations(char[][] field, int x, int y) {
        if (field[x][y] == 'X' || field[x][y] == 'O') {
            System.out.println("This cell is occupied! Choose another one!");
            return false;
        } else return true;
    }

    static int MakeYCorrect(int y) {
        return y == 1 ? 2 :
                y == 2 ? 4 : 6;
    }

    static boolean RightNumbers(int x, int y) {
        if (x > 3 || x < 1 || y > 3 || y < 1) {
            System.out.println("Coordinates should be from 1 to 3!");
            return false;
        } else return true;
    }

    static boolean NumbersException(String x, String y) {
        if (!x.matches("[0-9]+") || !y.matches("[0-9]+")) {
            System.out.println("You should enter numbers!");
            return false;
        } else return true;
    }

    static String[] splitCoordinates(String coordinates) {
        return coordinates.split(" ");
    }

    static String inputCoordinates(Scanner sc) {
        System.out.println("Enter the coordinates like [x y]: ");
        return sc.nextLine();
    }

    static void printEmptyField(char[][] field) {
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 9; j++) {
                if (j == 0 && i != 0 && i != 4 || j == 8 && i != 0 && i != 4) {
                    field[i][j] = '|';
                } else if (i == 0 || i == 4) {
                    field[i][j] = '-';
                } else {
                    field[i][j] = ' ';
                }
                System.out.print(field[i][j]);
            }
            System.out.println();
        }
    }
}

