package Modul10;

public class Player {

    private char[] playerSign;
    private int currentRaw;
    private int currentColumn;
    private int counter;


    Player(Field field) {
        playerSign = new char[4];
        playerSign[0] = '^';
        playerSign[1] = '>';
        playerSign[2] = 'v';
        playerSign[3] = '<';

        currentRaw = 3;
        currentColumn = 3;
        counter = 0;
        field.getField()[currentRaw][currentColumn] = playerSign[counter];

    }


    public void turnRight(Field field) {
        if (counter == 0 || counter == 1 || counter == 2) {
            counter += 1;
        } else {
            counter = 0;
        }
        field.getField()[currentRaw][currentColumn] = playerSign[counter];
    }

    public void turnLeft(Field field) {
        if (counter == 1 || counter == 2 || counter == 3) {
            counter -= 1;
        } else {
            counter = 3;
        }
        field.getField()[currentRaw][currentColumn] = playerSign[counter];

    }

    public void move(Field field) {

        field.getField()[currentRaw][currentColumn] = ' ';

        if (counter == 0 && currentRaw > 1) {
                currentRaw -= 1;
            } else if (counter == 1 && currentColumn < 8) {
                currentColumn += 1;
            } else if (counter == 2 && currentRaw < 8) {
                currentRaw += 1;
            } else if (counter == 3 && currentColumn > 1) {
                currentColumn -= 1;
            } else if (currentColumn == 1 || currentColumn == 8 || currentRaw == 1 || currentRaw == 8) {
                System.out.println("You can not go forward!");
            }

            field.getField()[currentRaw][currentColumn] = playerSign[counter];


    }
}



