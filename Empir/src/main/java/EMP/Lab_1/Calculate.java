package EMP.Lab_1;

import java.util.Arrays;
import java.util.Random;

/**
 * Created by oleg on 13.09.2015.
 */
public class Calculate {

    //variant + 10
    private static final int SIZE = 28;
    private static final int MAX_VALUE = 5;

    private int[] array = new int[SIZE];

    protected void initializeArray(){
        for(int i = 0; i < SIZE; i++) {
            array[i] = new Random().nextInt(MAX_VALUE) + 1;
            System.out.print(array[i] + " ");
        }
    }

    private void sortArrayByAsc(){
        Arrays.sort(array);
    }

    protected void getStatisticRow(){
        sortArrayByAsc();

        for (int i = 0; i < SIZE; i++)
            if ( i == 0 || array[i] != array[i - 1] )
                System.out.print(array[i] + " ");
    }

    protected void getIntegratedFrequency(){
        sortArrayByAsc();

        int freq = 0;
        for (int i = 0; i < SIZE; i++) {
            freq++;

            if(i == 0) { freq = 0; continue; }

            if(i == (SIZE - 1))
                System.out.println(freq+1);

            if(array[i] != array[i - 1]) {
                System.out.print(freq + " ");
                freq = 0;
            }
        }
    }

    protected void getAccumulatitedFrequency(){
        sortArrayByAsc();

        int acumFreq = 0;
        for(int i = 0; i < SIZE; i++){
            acumFreq++;

            if(i == 0){
                acumFreq = 0;
                continue;
            }

            if(i == (SIZE - 1))
                System.out.println(acumFreq + 1);

            if(array[i] != array[i - 1]) {
                System.out.print(acumFreq + " ");
            }
        }
    }

    protected void getFrequencies(){
        sortArrayByAsc();

        float freq = 0;
        for (int i = 0; i < SIZE; i++) {
            freq++;

            if(i == 0) { freq = 0; continue; }

            if(i == (SIZE - 1))
                System.out.format("%2.2f ", (freq + 1) / SIZE);

            if(array[i] != array[i - 1]) {
                System.out.format("%2.2f ",  freq / SIZE);
                freq = 0;
            }
        }
    }

    protected void sort(){
        System.out.println("\nVariations row: ");
        sortArrayByAsc();
        for(int i: array)
            System.out.print(i + " ");
    }
}
