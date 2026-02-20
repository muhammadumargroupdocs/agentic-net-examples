using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths for input (optional) and output presentation
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 400, 300);

        // Set plot area fill to solid light yellow
        chart.PlotArea.Format.Fill.FillType = Aspose.Slides.FillType.Solid;
        chart.PlotArea.Format.Fill.SolidFillColor.Color = Color.LightYellow;

        // Set plot area border (line) to solid dark blue with width 2
        chart.PlotArea.Format.Line.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        chart.PlotArea.Format.Line.Width = 2;
        chart.PlotArea.Format.Line.FillFormat.SolidFillColor.Color = Color.DarkBlue;

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}