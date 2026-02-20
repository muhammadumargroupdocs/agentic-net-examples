using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

public class Program
{
    public static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart to the slide
        Aspose.Slides.Charts.Chart chart = (Aspose.Slides.Charts.Chart)slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50f,   // X position
            50f,   // Y position
            500f,  // Width
            400f   // Height
        );

        // Validate layout to calculate actual positions
        chart.ValidateChartLayout();

        // Set chart title
        chart.HasTitle = true;
        chart.ChartTitle.AddTextFrameForOverriding("Sales Report 2025");
        chart.ChartTitle.TextFrameForOverriding.TextFrameFormat.CenterText = Aspose.Slides.NullableBool.True;

        // Customize legend position and size (fractions of chart dimensions)
        chart.Legend.X = 0.8f;      // 80% from left
        chart.Legend.Y = 0.1f;      // 10% from top
        chart.Legend.Width = 0.15f;
        chart.Legend.Height = 0.3f;
        chart.Legend.Overlay = false;

        // Save the presentation
        presentation.Save("ChartLegendTitle.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}