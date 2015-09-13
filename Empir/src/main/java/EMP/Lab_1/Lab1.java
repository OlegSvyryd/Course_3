package EMP.Lab_1;

/**
 * Created by oleg on 13.09.2015.
 */
public class Lab1 {
    public static void main(String[] args) {
        Calculate calculate = new Calculate();

        System.out.println("Initialize array: ");
        calculate.initializeArray();

        calculate.sort();

        System.out.println("\nStatistic separation: ");
        calculate.getStatisticRow();

        System.out.println("\nIntegrated frequency: ");
        calculate.getIntegratedFrequency();

        System.out.println("Accumulated frequency: ");
        calculate.getAccumulatitedFrequency();
    }
}
