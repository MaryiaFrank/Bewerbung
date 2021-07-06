package Modul10;

import java.util.Random;

public class Beeper {

    private char beeper;
    private int beeperRaw;
    private int beeperColumn;
    Random random = new Random();

    public int getBeeperRaw() {
        return beeperRaw;
    }

    public void setBeeper(char beeper) {
        this.beeper = beeper;
    }

    public int getBeeperColumn() {
        return beeperColumn;
    }

    Beeper (Field field){

            beeper = '*';
            beeperRaw = random.nextInt(8) + 1;
            beeperColumn = random.nextInt(8) + 1;
            if( field.getField()[beeperRaw][beeperColumn] != '^') {
            field.getField()[beeperRaw][beeperColumn] = beeper;
            }
            else {
                beeperRaw = random.nextInt(8) + 1;
                beeperColumn = random.nextInt(8) + 1;
            }



    }
}
