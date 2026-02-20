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

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50f, 50f, 500f, 400f);

        // Configure the plot area layout
        chart.PlotArea.AsILayoutable.X = 0f;
        chart.PlotArea.AsILayoutable.Y = 0f;
        chart.PlotArea.AsILayoutable.Width = 500f;
        chart.PlotArea.AsILayoutable.Height = 400f;
        chart.PlotArea.LayoutTargetType = Aspose.Slides.Charts.LayoutTargetType.Inner;

        // Save the presentation
        presentation.Save("ChartDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}