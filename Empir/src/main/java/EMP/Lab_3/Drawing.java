package EMP.Lab_3;

import com.xeiam.xchart.Chart;
import com.xeiam.xchart.ChartBuilder;
import com.xeiam.xchart.Histogram;
import com.xeiam.xchart.StyleManager;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by Oleg Svyryd on 05.10.2015.
 */
public class Drawing {
    protected Chart buildHistogram(List<Double> data, int h, float max, float min) {
        Chart chart = new ChartBuilder()
                .chartType(StyleManager.ChartType.Bar)
                .width(700).height(500).title("Histogram")
                .xAxisTitle("Values").yAxisTitle("Count").build();

        Histogram histogram = new Histogram(data, h, (double)min, (double)max);
        chart.addSeries("Histogram", histogram.getxAxisData(), histogram.getyAxisData());
        return chart;
    }

    protected Chart buildPolygon(List<Double> data, int h, float max, float min) {
        Chart chart = new ChartBuilder()
                .chartType(StyleManager.ChartType.Line)
                .width(700).height(500).title("Polygon")
                .xAxisTitle("Values").yAxisTitle("Count").build();

        Histogram histogram = new Histogram(data, h, (double)min, (double)max);
        chart.addSeries("Polygon", histogram.getxAxisData(), histogram.getyAxisData());

        return chart;
    }
}
