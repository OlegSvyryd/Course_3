package EMP.Lab_2;

import junit.framework.Assert;
import org.junit.AfterClass;
import org.junit.BeforeClass;
import org.junit.FixMethodOrder;
import org.junit.Test;
import org.junit.runners.MethodSorters;

import java.util.List;

import static org.junit.Assert.assertNotNull;

/**
 * Created by Oleg Svyryd on 04.10.2015.
 */

@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class TestLab2 {

    private static Mode actualMode = new Mode();
    private static MedianAndAverage actualMedianAndAverage = new MedianAndAverage();

    private static final int[] testMode1 = new int[] { 3, 1, 5, 2, 7, 7, 4, 1, 3, 8, 8, 4, 3, 7, 7, 2, 1, 3, 4, 1, 8, 8, 2, 5, 11, 12, 11};
    private static final int[] testMode2 = new int[] { 3, 1, 5, 2, 7, 7, 7, 1, 3, 8, 7, 4, 3, 7, 7, 2, 1, 3, 4, 7, 8, 8, 7, 5, 11, 12, 11};
    private static final int[] testOddMedian = new int[] { 3, 1, 5, 4, 6};
    private static final int[] testEvenMedian = new int[] { 3, 2, 5, 4};

    @BeforeClass
    public static void runBeforeClass() {
        System.out.println("Begin testing..");
    }

    @AfterClass
    public static void runAfterClass() {
        actualMode = null;
        actualMedianAndAverage = null;
        System.out.println("End testing.");
    }

    @Test
    public void test01MultipleModes() {
        List<Integer> modes = actualMode.getMode(testMode1);

        System.out.println("Multiple mode: ");
        printTestArray(testMode1);
        System.out.println(modes);

        assertNotNull(modes);
    }

    @Test
    public void test02SingleMode() {
        List<Integer> modes = actualMode.getMode(testMode2);

        System.out.println("Single mode: ");
        printTestArray(testMode2);
        System.out.println(modes);

        assertNotNull(modes);
    }

    @Test
    public void test03OddMedian() {
        float median = actualMedianAndAverage.getMedian(testOddMedian);
        System.out.println("Median for odd length: ");
        printTestArray(testOddMedian);
        System.out.println(median);

        assertNotNull(median);
    }

    @Test
    public void test04EvenMedian() {
        float median = actualMedianAndAverage.getMedian(testEvenMedian);
        System.out.println("Median for even length: ");
        printTestArray(testEvenMedian);
        System.out.println(median);

        assertNotNull(median);
    }

    @Test
    public void test05Average() {
        float average = actualMedianAndAverage.getAverage(testMode2);

        System.out.println("Average: ");
        printTestArray(testMode2);
        System.out.format("%2.2f\n", average);

        assertNotNull(average);
    }

    private static void printTestArray(int[] arr) {
        for(int i : arr) {
            System.out.print(i + " ");
        }
        System.out.println();
    }
}
