using System;

public class Program
{
    public static void Main()
    {
        string outputPath = "SeriesCollection.pptx";

        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50f, 50f, 500f, 400f);

        Aspose.Slides.Charts.IChartSeriesCollection seriesCollection = chart.ChartData.Series;

        foreach (Aspose.Slides.Charts.ChartSeries seriesItem in seriesCollection)
        {
            foreach (Aspose.Slides.Charts.IChartDataPoint dataPoint in seriesItem.DataPoints)
            {
                // Set a built‑in number format (e.g., 10 = Currency)
                dataPoint.Value.AsCell.PresetNumberFormat = 10;
            }
        }

        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}