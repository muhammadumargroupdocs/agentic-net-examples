using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 450, 300);

        // Turn off automatic scaling for the vertical (value) axis
        chart.Axes.VerticalAxis.IsAutomaticMinValue = false;
        chart.Axes.VerticalAxis.IsAutomaticMaxValue = false;
        chart.Axes.VerticalAxis.IsAutomaticMajorUnit = false;
        chart.Axes.VerticalAxis.IsAutomaticMinorUnit = false;

        // Set custom axis scale values
        chart.Axes.VerticalAxis.MinValue = 0;      // Minimum value
        chart.Axes.VerticalAxis.MaxValue = 200;    // Maximum value
        chart.Axes.VerticalAxis.MajorUnit = 50;    // Major unit interval
        chart.Axes.VerticalAxis.MinorUnit = 10;    // Minor unit interval

        // Save the presentation to a PPTX file
        presentation.Save("AxisScaleDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}