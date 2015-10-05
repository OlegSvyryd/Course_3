package EMP.Lab_3;

import com.xeiam.xchart.*;
import javafx.scene.shape.Polygon;

import java.awt.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

/**
 * Created by Oleg Svyryd on 05.10.2015.
 */
public class Calculate {

    protected static Random random = new Random();

    /**
     * Generate random float numbers in range
     * @param min Min range
     * @param max Max range
     * @return Random value in range above
     */
    public static float randomInRange(float min, float max) {
        float range = max - min;
        float scaled = (float)random.nextDouble() * range;
        float shifted = scaled + min;
        return shifted; // == (rand.nextDouble() * (max-min)) + min;
    }

    /**
     * Initialize array random numbers
     */
    protected void initializeArray(float[] arr, int amountItems){
        for(int i = 0; i < arr.length; i++) {
            arr[i] = randomInRange(0, amountItems);
            System.out.format("%2.2f ", arr[i]);
        }
    }

    /**
     * Return amount of groups
     * @return
     */
    protected static int getH(int amountItems) {
        return (int) Math.floor(sterdjessFormule(amountItems));
    }

    /**
     * Return step of interval
     * @return
     */
    protected float getStepInterval(float[] arr, int amountItems) {
        float stepInterval = (getMaxElement(arr) - getMinElement(arr)) / getH(amountItems);
        System.out.println("Step interval: " + stepInterval);
        return Math.round(stepInterval);
    }

    /**
     * Get maximum element from array
     * @param arr Array of numbers
     * @return Maximum element from array
     */
    protected static float getMaxElement(float[] arr) {

        //set max element
        float max = 0;

        //flag if value is first in collection
        boolean isFirstEnter = false;

        //iterating collection of frequencies
        for(int i = 0; i < arr.length; i++) {

            //get concrete value
            float value = arr[i];

            //check if iteration is first
            if(!isFirstEnter) {

                //set max value first value from array
                max = value;

                //flag that was first iteration
                isFirstEnter = true;
            }

            //check if max value not largest that previous value
            if(max < value) {

                //set max value to actual value
                max = value;
            }
        }

        //return max value or values
        return max;
    }

    /**
     * Get maximum element from array
     * @param arr Array of numbers
     * @return Maximum element from array
     */
    protected static float getMinElement(float[] arr) {

        //set min element
        float min = 0;

        //flag if value is first in collection
        boolean isFirstEnter = false;

        //iterating collection of frequencies
        for(int i = 0; i < arr.length; i++) {

            //get concrete value
            float value = arr[i];

            //check if iteration is first
            if(!isFirstEnter) {

                //set min value first value from array
                min = value;

                //flag that was first iteration
                isFirstEnter = true;
            }

            //check if min value largest that previous value
            if(min > value) {

                //set min value to actual value
                min = value;
            }
        }

        //return min value or values
        return min;
    }

    /**
     * Sterjess Formule
     * @param amountItems Amount items in array
     * @return Result
     */
    private static final double sterdjessFormule(int amountItems) {
        return (1 + 3.322 * Math.log(amountItems));
    }

    /**
     * Convert array to List(need for draw graphics)
     * @param amountItems Amount items in array
     * @param arr Array of items
     * @return List of items
     */
    protected List<Double> getGaussianData(int amountItems, float[] arr) {

        List<Double> data = new ArrayList<Double>(amountItems);
        for (int i = 0; i < amountItems; i++) {
            data.add((double)arr[i]);
        }
        return data;
    }
}
