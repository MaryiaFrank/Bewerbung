package Modul10;

public class Field {

        private char[][] field;

        Field() {
            field = new char[10][10];
        }

    public char[][] getField() {
        return field;
    }

    public void setField(char[][] field) {
        this.field = field;
    }

        public void buildField() {
            for (int i = 0; i < field.length; i++) {
                for (int j = 0; j < field[i].length; j++) {
                    if (i == 0 || i == 9 || j == 0 || j == 9) {
                        field[i][j] = '#';
                    } else {
                        field[i][j] = ' ';
                    }
                }
            }
        }

        //Print on Console
        public void printField() {

            for (int i = 0; i < field.length; i++) {
                for (int j = 0; j < field[i].length; j++) {
                    System.out.print(field[i][j]);
                }
                System.out.println();
            }
        }


}


