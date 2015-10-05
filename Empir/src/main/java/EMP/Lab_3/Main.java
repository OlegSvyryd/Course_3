package EMP.Lab_3;

import com.xeiam.xchart.SwingWrapper;

/**
 * Created by Oleg Svyryd on 05.10.2015.
 */
public class Main {
    private static final int N = 18;
    private static final int AMOUNT_ITEMS = 100 * N;
    private static float[] array = new float[AMOUNT_ITEMS];

    public static void main(String[] args) {
        Calculate calculate = new Calculate();
        Drawing drawing = new Drawing();

        calculate.initializeArray(array, AMOUNT_ITEMS);
        System.out.println("\nAmount groups: " + calculate.getH(AMOUNT_ITEMS));

        System.out.format("Max element: %2.2f\n", Calculate.getMaxElement(array));
        System.out.format("Min element: %2.2f\n", Calculate.getMinElement(array));
        System.out.println("Floor step interval: " + calculate.getStepInterval(array, AMOUNT_ITEMS));

        new SwingWrapper(drawing.buildHistogram(calculate.getGaussianData(AMOUNT_ITEMS, array), calculate.getH(AMOUNT_ITEMS), Calculate.getMaxElement(array), Calculate.getMinElement(array))).displayChart();
        new SwingWrapper(drawing.buildPolygon(calculate.getGaussianData(AMOUNT_ITEMS, array), calculate.getH(AMOUNT_ITEMS), Calculate.getMaxElement(array), Calculate.getMinElement(array))).displayChart();
    }
}
