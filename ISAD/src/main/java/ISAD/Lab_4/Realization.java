package ISAD.Lab_4;

import java.text.DecimalFormat;
import java.util.Random;
import java.util.Scanner;

public class Realization {

    int I = 5;
    double alpha = 0.5;
    double min_alpha = 0.2;
    double[] w = new double[I];
    double current_input[] = new double[I];
    double[][] x = {
            {50, 20, 7, 3, 44},
            {101, 86, 14, 55, 91},
            {88, 8, 30, 20, 34},
            {127, 26, 10, 95, 114},
            {130, 61, 10, 7, 72},
            {166, 89, 30, 26, 74},
            {155, 96, 24, 36, 141},
            {125, 36, 4, 9, 101},
            {52, 21, 7, 3, 45},
            {111, 86, 14, 55, 90},
            {188, 8, 30, 20, 54},
            {127, 26, 10, 95, 110},
            {138, 68, 10, 7, 78},
            {169, 29, 30, 26, 79},
            {155, 96, 24, 16, 140},
            {145, 36, 4, 9, 110},
            {150, 120, 17, 3, 144},
            {141, 86, 14, 55, 491},
            {208, 8, 130, 20, 134},
            {127, 26, 10, 95, 116}
    };
    DecimalFormat df = new DecimalFormat("#.####");
    double min = 0;
    int min_p = 0;

    public void go() {

        randomizeWeights();

        for (int T = 0; T < 300; T++) {
            current_input = x[T % x.length];

            double sum = 0;
            for (int i = 0; i < I; i++) {
                sum += w[i] * current_input[i];
            }
            System.out.println("Епоха: " + T + "    Результат: " + sum);
            updateWeights();

            alpha -= 0.0005;
        }

        System.out.println("Фінальні ваги :\n");

        for (int j = 0; j < I; j++) {
            System.out.println(w[j]);
        }

        for(int i =0;i<3;i++)
        {
            System.out.println("\n Навчання завершено. Введіть тестовий приклад :\n");
            Scanner sc = new Scanner(System.in);
            double res = 0;
            for(int j=0;j<5;j++)
                res += sc.nextDouble()*w[j];

            System.out.println("Результат: " + res);
        }
    }

    private void randomizeWeights() {
        Random r = new Random();
        for (int i = 0; i < I; i++) {
            for (int j = 0; j < I; j++) {
                w[i] = (r.nextDouble());
            }
        }
    }

    private void updateWeights() {

        for (int X = 0; X < I; X++) {
            w[X] += alpha * (current_input[X] - w[X]);
        }
    }

    public static void main(String[] args)    {
        new Realization().go();
    }
}

