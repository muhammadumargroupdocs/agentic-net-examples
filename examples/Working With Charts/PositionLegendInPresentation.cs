using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        // Add a clustered column chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 400f, 300f);
        // Position the legend using custom fractional coordinates
        chart.Legend.X = 0.8f;      // 80% from the left of the chart
        chart.Legend.Y = 0.1f;      // 10% from the top of the chart
        chart.Legend.Width = 0.15f; // 15% of the chart width
        chart.Legend.Height = 0.3f; // 30% of the chart height
        // Save the presentation
        presentation.Save("LegendPosition.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}