using System;
namespace ChartAxesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a clustered column chart
            Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 450, 300);

            // Set the horizontal axis to be positioned between categories
            chart.Axes.HorizontalAxis.AxisBetweenCategories = true;

            // Set the distance of category axis labels from the axis (0-1000%)
            chart.Axes.HorizontalAxis.LabelOffset = 100; // 10%

            // Save the presentation
            presentation.Save("ChartAxes.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}