using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a bubble chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Bubble, 50f, 50f, 600f, 400f);

        // Set bubble size representation to Width
        chart.ChartData.SeriesGroups[0].BubbleSizeRepresentation = Aspose.Slides.Charts.BubbleSizeRepresentationType.Width;

        // Get the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Clear any default data points
        series.DataPoints.Clear();

        // Add bubble data points (X, Y, Size)
        series.DataPoints.AddDataPointForBubbleSeries(1.0, 2.0, 3.0);
        series.DataPoints.AddDataPointForBubbleSeries(2.0, 3.0, 4.0);
        series.DataPoints.AddDataPointForBubbleSeries(3.0, 4.0, 5.0);

        // Save the presentation
        presentation.Save("BubbleChart.pptx", SaveFormat.Pptx);
    }
}