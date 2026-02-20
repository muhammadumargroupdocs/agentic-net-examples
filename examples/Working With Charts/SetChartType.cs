using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a chart of type ClusteredColumn
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50f, 50f, 400f, 300f);

        // Set layout mode for the chart's plot area
        chart.PlotArea.AsILayoutable.X = 0f;
        chart.PlotArea.AsILayoutable.Y = 0f;
        chart.PlotArea.AsILayoutable.Width = 400f;
        chart.PlotArea.AsILayoutable.Height = 300f;
        chart.PlotArea.LayoutTargetType = Aspose.Slides.Charts.LayoutTargetType.Inner;

        // Change the chart type to Pie
        chart.Type = Aspose.Slides.Charts.ChartType.Pie;

        // Save the presentation
        presentation.Save("SetChartType.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}