package ISAD.Lab_1;

/**
 * Created by oleg on 13.09.2015.
 */
public class Perceptron {

    private static final float T = 0.5f;
    private double[] enters;
    private double outer;
    private double[] weights;

    double[][] patterns = {
            {0,0, 0},
            {0,1, 1},
            {1,0, 1},
            {1,1, 1}
    };

    public Perceptron() {
        enters = new double[2];
        weights = new double[enters.length];
        for(int i = 0; i < enters.length; i++)
            weights[i] = Math.random() * 0.2 + 0.1;
    }

    private void countOuter(){
        outer = 0;
        for(int i = 0; i < enters.length; i++)
            outer += enters[i] * weights[i];

        if(outer > T)
            outer = 1;
        else
            outer = 0;
    }

    private int study(){
        double gError = 0;

        int iteration = 0;
        do{
            iteration++;
            gError = 0;

            for(int p = 0; p < patterns.length; p++){
                enters = java.util.Arrays.copyOf(patterns[p], patterns[p].length - 1);

                countOuter();

                double localError = patterns[p][2] - outer;
                gError += Math.abs(localError);

                for(int i = 0; i < enters.length; i++)
                    weights[i] += 0.1 * localError * enters[i];

            }
        } while(gError != 0);

        return iteration;
    }

    private void test() {
        int iterations = study();
        System.out.println("iterations: " + iterations);

        for (int p = 0; p < patterns.length; p++) {
            enters = java.util.Arrays.copyOf(patterns[p], patterns[p].length - 1);

            countOuter();
            System.out.println(outer);
        }
    }

    public static void main(String[] args) {
        Perceptron perceptron = new Perceptron();

        perceptron.test();
    }
}


    //truth table
//    private static final boolean[][] truth = {
//            { false, false, false },
//            { false, false, true },
//            { false, true, false },
//            { false, true, true },
//            { true, false, false },
//            { true, false, true },
//            { true, true, false },
//            { true, true, true }
//    };