package ISAD.Lab_3;

import java.math.BigDecimal;
import java.math.RoundingMode;

public class Realization {
    double[][] x1 = {
            {0, 1, 1, 0},
            {1, 1, 0, 0},
            {0, 0, 1, 1},
            {1, 0, 1, 0}
    };
    double[] w1 = {0.2, 0.4, 0.1, 0.1};
    double[] w2 = {0.5, 0.6, 0.6, 0.3};
    double n = 0.8;

    public void calc() {
        double sum1 = 0, sum2 = 0;
        int g = 0;
        while (g < 1) {

            for (int i = 0; i < 4; i++) {
                sum1 = 0;
                sum2 = 0;
                for (int j = 0; j < 4; j++) {
                    sum1 += Math.pow(x1[i][j] - w1[j], 2);
                    sum2 += Math.pow(x1[i][j] - w2[j], 2);
                }
                System.out.println(sum1);
                System.out.println(sum2);

                if (sum1 < sum2) {
                    System.out.println("x1 ближче до w1");

                    for (int m = 0; m < 4; m++) {

                        w1[m] = w1[m] - n * (w1[m] - x1[i][m]);
                        w1[m] = new BigDecimal(w1[m]).setScale(2, RoundingMode.HALF_UP).doubleValue();

                        System.out.println("Нова вага w1 = " + w1[m]);
                    }
                } else {
                    System.out.println("x1 ближче до w2");
                    for (int m = 0; m < 4; m++) {
                        w2[m] = w2[m] - n * (w2[m] - x1[i][m]);
                        w2[m] = new BigDecimal(w2[m]).setScale(2, RoundingMode.HALF_UP).doubleValue();
                        System.out.println("Нова вага w2 = " + w2[m]);
                    }
                }
            }
            g++;
        }
    }
}
