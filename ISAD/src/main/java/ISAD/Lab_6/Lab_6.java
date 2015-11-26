import javax.swing.*;

public class Lab_6 {

    private static final int MAX_I = 5;
    private static final int MAX_J = 7;
    private static final int INPUTS = 7;
    private static final int INPUT_TESTS = 6;
    private static final double Z = 0.96;
    private static final double MIN_ALPHA = 0.01;
    private static final double A = 0.023;
    private static final double A0 = 0.04;
    private double alpha = 0.6;
    private double d[] = new double[MAX_I];
    private double w[][] = {{0.2, 0.6, 0.5, 0.9, 0.4, 0.2, 0.8},
            {0.9, 0.3, 0.6, 0.4, 0.5, 0.6, 0.3},
            {0.8, 0.5, 0.7, 0.2, 0.6, 0.9, 0.5},
            {0.6, 0.4, 0.2, 0.3, 0.7, 0.2, 0.4},
            {0.8, 0.9, 0.7, 0.9, 0.3, 0.2, 0.5}};
    private int pattern[][] = {{1, 1, 1, 0, 0, 0, 0},
            {0, 0, 0, 0, 1, 1, 1},
            {0, 0, 1, 1, 1, 0, 0},
            {0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 1, 0, 0, 0},
            {1, 0, 1, 0, 1, 0, 1}};
    private int tests[][] = {{1, 1, 1, 1, 0, 0, 0},
            {0, 1, 1, 0, 1, 1, 1},
            {0, 1, 0, 1, 0, 1, 0},
            {0, 1, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 1, 0, 0},
            {0, 0, 0, 1, 1, 1, 1}};
    private StringBuilder jTextArea1 = new StringBuilder();

    private double func() {
        double sum = 0;
        for (int i = 0; i < MAX_I; i++) {
            for (int j = 0; j < MAX_J; j++) {
                sum += A0 + A * tests[i][j];
            }
        }
        return sum;
    }

    private void training() {
        int iterations = 0;
        boolean reductionFlag = false;
        int critValue = 0;
        int dMin = 0;

        while (alpha > MIN_ALPHA) {
            iterations += 1;

            for (int vecNum = 0; vecNum <= (INPUTS - 1); vecNum++) {

                computeInput(pattern, vecNum);
                dMin = minimum(d);
                updateWeights(vecNum, dMin);
            }
            alpha = Z * alpha;
            if (alpha < A) {
                if (reductionFlag == false) {
                    reductionFlag = true;
                    critValue = iterations;
                }
            }
        }

        return;
    }

    private void computeInput(int[][] vectorArray, int vectorNumber) {
        clearArray(d);
        for (int i = 0; i <= (MAX_I - 1); i++) {
            for (int j = 0; j <= (MAX_J - 1); j++) {
                d[i] += Math.pow((w[i][j] - vectorArray[vectorNumber][j]), 2);
            } // j
        } // i
        return;
    }
    private void updateWeights(int vectorNumber, int dMin) {
        for (int i = 0; i <= (MAX_J - 1); i++) {

            w[dMin][i] = w[dMin][i] + (alpha * (pattern[vectorNumber][i] - w[dMin][i]));
            if (alpha > A) {
                if ((dMin > 0) && (dMin < (MAX_I - 1))) {
                    w[dMin - 1][i] = w[dMin - 1][i] + (alpha * (pattern[vectorNumber][i] - w[dMin - 1][i]));
                    w[dMin + 1][i] = w[dMin + 1][i] + (alpha * (pattern[vectorNumber][i] - w[dMin + 1][i]));
                } else {
                    if (dMin == 0) {
                        w[dMin + 1][i] = w[dMin + 1][i] + (alpha * (pattern[vectorNumber][i] - w[dMin + 1][i]));
                    } else {
                        w[dMin - 1][i] = w[dMin - 1][i] + (alpha * (pattern[vectorNumber][i] - w[dMin - 1][i]));
                    }
                }
            }
        } // i
        return;
    }

    private void clearArray(double[] nodeArray) {
        for (int i = 0; i <= (MAX_I - 1); i++) {
            nodeArray[i] = 0.0;
        } // i
        return;
    }

    private int minimum(double[] nodeArray) {
        int winner = 0;
        boolean foundNewWinner = false;
        boolean done = false;
        while (!done) {
            foundNewWinner = false;
            for (int i = 0; i <= (MAX_I - 1); i++) {
                if (i != winner) {
                    if (nodeArray[i] < nodeArray[winner]) {
                        winner = i;
                        foundNewWinner = true;
                    }
                }
            } // i

            if (foundNewWinner == false) {
                done = true;
            }
        }
        return winner;
    }

    private void printResults() {
        int dMin = 0;
        jTextArea1.append("Тестування:\n");
        for (int vecNum = 0; vecNum <= (INPUTS - 1); vecNum++) {
            computeInput(pattern, vecNum);
            dMin = minimum(d);
            for (int i = 0; i <= (MAX_J - 1); i++) {
                dMin = minimum(d);
            } // i

        }
        jTextArea1.append("------------------------------------------------------------------------\n");
        for (int i = 0; i <= (MAX_I - 1); i++) {
            jTextArea1.append("Коефіцієнти " + i + " ітерації:\n");
            jTextArea1.append("     ");
            for (int j = 0; j <= (MAX_J - 1); j++) {
                jTextArea1.append(w[i][j] + ", ");
            } // j
            jTextArea1.append("\n");
        } // i

        jTextArea1.append("------------------------------------------------------------------------\n");
        jTextArea1.append("Результати:\n");
        for (int vecNum = 0; vecNum <= (INPUT_TESTS - 1); vecNum++) {
            computeInput(tests, vecNum);
            dMin = minimum(d);

            jTextArea1.append(") \t прогнозований коефіцієнт А("+vecNum+"): " + dMin + "\n");
        }
        return;        }

    public void start() {
        training();
        printResults();
        System.out.println(jTextArea1);
        return;
    }

    public static void main(String[] args) {
        new Lab_6().start();
    }
}

