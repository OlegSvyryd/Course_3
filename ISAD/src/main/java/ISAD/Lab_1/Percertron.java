package ISAD.Lab_1;

/**
 * Created by oleg on 13.09.2015.
 */
public class Percertron {

    private double TETA = 0; // Поріг спрацювання функції
    private final double H = 0.1; // Крок ( коофіцієнт швидкості навчання )
    private double[] w = new double[3]; // Вагові коофіцієнти
    private final int[][] xInt = new int[8][3]; // x1, x2, x3
    private final int[] T = new int[8]; // Істинне значення функції

    Percertron() {

        w[0] = 0.3;
        w[1] = 0.4;
        w[2] = 0.5;

        boolean[][] xBool = new boolean[8][3];
        xBool[0][0] = false;
        xBool[0][1] = false;
        xBool[0][2] = false;
        xBool[1][0] = false;
        xBool[1][1] = false;
        xBool[1][2] = true;
        xBool[2][0] = false;
        xBool[2][1] = true;
        xBool[2][2] = false;
        xBool[3][0] = false;
        xBool[3][1] = true;
        xBool[3][2] = true;
        xBool[4][0] = true;
        xBool[4][1] = false;
        xBool[4][2] = false;
        xBool[5][0] = true;
        xBool[5][1] = false;
        xBool[5][2] = true;
        xBool[6][0] = true;
        xBool[6][1] = true;
        xBool[6][2] = false;
        xBool[7][0] = true;
        xBool[7][1] = true;
        xBool[7][2] = true;

        boolean[] tBool = new boolean[8];

        for (int i = 0; i < 8; i++)
            tBool[i] = (!xBool[i][0] && (!xBool[i][1] || xBool[i][2]));

        for (int i = 0; i < 8; i++)
            if (tBool[i])
                T[i] = 1;
            else
                T[i] = 0;

        for (int i = 0; i < 8; i++) {
            for (int j = 0; j < 3; j++)
                if (xBool[i][j])
                    xInt[i][j] = 1;
                else
                    xInt[i][j] = 0;
        }
    }

    public void printTab() {
        System.out.println("Таблиця істинності:\n\n x1 x2 x3  T");
        for (int i = 0; i < 8; i++) {
            for (int j = 0; j < 3; j++)
                System.out.printf("  %1d", xInt[i][j]);
            System.out.printf("%3d\n", T[i]);
        }
        System.out.println();
    }

    public void startStudyPerceptron() {
        boolean work = true; // Відповідає за припинення роботи перцептрону
        double a;
        int Y;
        int delta;

        double w1, w2, w3, pTETA, nTminusY, dTETA; // Змінні які потрібні для подальшого виводу результатів
        double[] dw = new double[3]; // Змінні які потрібні для подальшого виводу результатів

        while (work) {
            work = false;
            for (int i = 0; i < 8; i++) {
                a = 0;
                for (int j = 0; j < 3; j++)
                    a += xInt[i][j] * w[j];
                if (a > TETA) Y = 1;
                else Y = 0;
                if (Y != T[i]) {
                    work = true;
                    w1 = w[0];
                    w2 = w[1];
                    w3 = w[2];
                    pTETA = TETA; // Для виводу результатів
                    delta = T[i] - Y;
                    nTminusY = delta * H;
                    for (int j = 0; j < 3; j++) {
                        dw[j] = H * delta * xInt[i][j];
                        w[j] += dw[j];
                    }
                    dTETA = H * delta;
                    TETA -= dTETA;
                    System.out.printf("%2.2f  %2.2f  %2.2f  %2.2f  %2d  %2d  %2d  " +
                                    "%2.2f  %2d  %2d  %+4.2f  %+4.2f  %+4.2f  %+4.2f  %+4.2f\n",
                            w1, w2, w3, pTETA, xInt[i][0], xInt[i][1], xInt[i][2],
                            a, Y, T[i], nTminusY, dw[0], dw[1], dw[2], dTETA);
                }
            }
        }
    }

    public static void main(String[] args) {
        Percertron perceptron = new Percertron();
        perceptron.printTab();
        System.out.println("  w1   w2   w3    Teta  x1  x2  x3     a   Y   T   H(T-Y)  dw1    dw2    dw3  dTeta");
        perceptron.startStudyPerceptron();
    }

}
