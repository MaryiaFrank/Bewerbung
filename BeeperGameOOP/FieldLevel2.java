package Modul10;

public class FieldLevel2 {

    private char [][] field2;

    FieldLevel2 (){
        field2 = new char[10][20];
    }

    public void BuildField2(){
        for (int i = 0; i < field2.length; i++){
            for (int j = 0; j < field2.length; j++){
                field2[i][j] = ' ';
                field2[i][0] = '#';
                field2[i][9] = '#';
                field2[i][11] = '#';
                field2[i][19] = '#';
                field2[0][j] = '#';
                field2[9][j] = '#';




            }
        }
    }

    public void printField2(){
        for (int i = 0; i < field2.length; i++) {
            for (int j = 0; j < field2[i].length; j++) {
                System.out.print(field2[i][j]);
            }
            System.out.println();
        }
    }
}

