/*
package EMP.Lab_7;

import java.io.*;
import java.util.logging.Logger;

*/
/**
 * Created by Oleg Svyryd on 08.11.2015.
 *//*

public class FileUtil {
    private static final Logger LOG = Logger.getAnonymousLogger();

    private static final int N = 48;
    private static File actual;

    private static File createFile(String name) {
        actual = new File(name);

        try {
            if (actual.createNewFile()){
                LOG.info("File is created!");
            }else{
                LOG.info("File already exists.");
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

        return actual;
    }

    public void fillFile(int[] data) {
        actual = FileUtil.createFile("test.txt");

        try(BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(actual))) {
            for(int i = 0; i < data.length; i++) {
                bufferedWriter.write(pushRow(data[i]));
                bufferedWriter.newLine();
            }
        } catch (IOException e) {
            LOG.warning(e.getMessage());
        }
    }

    public int[] getData() {
        int[] data = new int[N];

        try(BufferedReader bufferedReader = new BufferedReader(new FileReader(actual))){
            String strLine;
            int count = 0;
            while ((strLine = bufferedReader.readLine()) != null) {
                data[count++] = getRow(strLine);
            }
        } catch (FileNotFoundException e) {
            LOG.warning(e.getMessage());
        } catch (IOException e) {
            LOG.warning(e.getMessage());
        } catch (NumberFormatException e) {
            LOG.warning(e.getMessage());
        }

        return data;
    }

    private static String pushRow(int digit) {
        return Integer.valueOf(digit).toString();
    }
    private static int getRow(String strLine) {
        return Integer.parseInt(strLine);
    }
}*/
