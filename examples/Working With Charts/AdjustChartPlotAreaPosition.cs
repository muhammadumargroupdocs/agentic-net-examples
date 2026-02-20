using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 400f, 300f);
        chart.PlotArea.AsILayoutable.X = 0.1f;
        chart.PlotArea.AsILayoutable.Y = 0.1f;
        chart.PlotArea.AsILayoutable.Width = 0.8f;
        chart.PlotArea.AsILayoutable.Height = 0.8f;
        chart.PlotArea.LayoutTargetType = Aspose.Slides.Charts.LayoutTargetType.Inner;
        presentation.Save("AdjustPlotArea.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}