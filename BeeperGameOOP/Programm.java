package Modul10;

import java.util.Scanner;

public class Programm {
    public static void main(String[] args) {

        int BeeperCounter = 0;

        Field fieldGame = new Field();
        fieldGame.buildField();

        Player player1 = new Player(fieldGame);

        Beeper beeper1 = new Beeper(fieldGame);
        Beeper beeper2 = new Beeper(fieldGame);


        fieldGame.printField();

        String decision;
        Scanner sc = new Scanner(System.in);


        do
        {
            System.out.println("turn left: l , turn right: r , move: m, pick up: p");

            decision = sc.next();

            switch (decision) {
                case "r":
                    player1.turnRight(fieldGame);
                    fieldGame.printField();
                    break;
                case "l":
                    player1.turnLeft(fieldGame);
                    fieldGame.printField();
                    break;
                case "m":
                    player1.move(fieldGame);
                    fieldGame.printField();
                    break;
                case "p":
                    BeeperCounter += 1;
                    break;
                default:
                    System.out.println("Wrong order!");
                    break;
            }

        }while (BeeperCounter < 2);


        FieldLevel2 fieldGame2 = new FieldLevel2();
        fieldGame2.BuildField2();
        fieldGame2.printField2();



    }
}
