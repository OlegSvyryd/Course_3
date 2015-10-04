package EMP.Lab_2;

import java.util.Arrays;
import java.util.Random;

/**
 * Created by Oleg Svyryd on 02.10.2015.
 */
public class MedianAndAverage {

    /**
     * Return median for even arrays
     * @param array Init array of digits
     * @return median
     */
    private static float getMedianForEvenArrays(int[] array) {
        return ((float) (array[((array.length / 2) - 1)] + array[((array.length / 2))]) / 2);
    }

    /**
     * Return median for odd arrays
     * @param array Init array of digits
     * @return median
     */
    private static int getMedianForOddArrays(int[] array) {
        return (array[((array.length / 2))]);
    }

    /**
     * Check length of array and return median
     * @param array Init array of digits
     * @return median
     */
    public float getMedian(int[] array) {
        return ( (array.length % 2) == 0) ? getMedianForEvenArrays(array) : getMedianForOddArrays(array);
    }

    /**
     * Return average of array
     * @param array Init array of digits
     * @return average
     */
    public float getAverage(int[] array) {
        float sum = 0;
        for(int i : array) {
            sum += i;
        }
        return sum / array.length;
    }
}
