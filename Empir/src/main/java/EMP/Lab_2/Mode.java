package EMP.Lab_2;

import java.util.*;

/**
 * Created by Oleg Svyryd on 04.10.2015.
 */
public class Mode {
    /**
     * Array frequencies of init array
     * @param array Row of numbers(array)
     */
    private static Map<Integer, Integer> getFrequencies(int[] array) {
        //create map that contains modes
        Map<Integer, Integer> modes = new HashMap<Integer, Integer>();

        for(int i = 0; i < array.length; i++) {

            //get from map value from unsorted array
            Integer value = modes.get(array[i]);

            //if value isn't exist
            if(value == null) {

                //put instead value 0
                modes.put(array[i], 0);
            }

            //else if value is exist
            else {

                //get amount of this values
                int count = value.intValue();

                //increment amount
                count++;

                //put new incremented value
                modes.put(array[i], count);
            }
        }
        return modes;
    }

    /**
     * Get maximum frequencies or frequency
     * @param setValues Set of frequencies
     * @return Max frequencies or frequency
     */
    private static int getMaxFrequency(Collection<Integer> setValues) {

        //set max element
        int max = 0;

        //flag if value is first in collection
        boolean isFirstEnter = false;

        //iterating collection of frequencies
        for(Iterator<Integer> iterator = setValues.iterator(); iterator.hasNext();) {

            //get concrete value
            Integer value = iterator.next();

            //check if iteration is first
            if(!isFirstEnter) {

                //set max value first value from collection
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
     * Return modes of array
     * @param array Row of numbers(array)
     */
    public List<Integer> getMode(int[] array) {
        //map with frequencies
        Map<Integer, Integer> modes = new HashMap<Integer, Integer>();

        //get frequencies
        modes = getFrequencies(array);

        //get max frequency
        int maxFreq = getMaxFrequency(modes.values());

        //create list of modes
        List<Integer> listOfModes = new ArrayList<Integer>();

        //iterate frequencies
        for(Map.Entry<Integer, Integer> entry : modes.entrySet()) {

            //set actual frequency
            Integer actual = entry.getValue();

            //check if actual equals max frequency
            if(actual == maxFreq) {

                //add mode into list
                listOfModes.add(entry.getKey());
            }
        }

        //return list of modes
        return listOfModes;
    }
}
