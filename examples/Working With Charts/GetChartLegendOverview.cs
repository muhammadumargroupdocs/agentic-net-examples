using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add a clustered column chart on the first slide
        Aspose.Slides.Charts.Chart chart = (Aspose.Slides.Charts.Chart)pres.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);
        chart.ValidateChartLayout();

        // Access chart title and legend
        Aspose.Slides.Charts.ChartTitle chartTitle = (Aspose.Slides.Charts.ChartTitle)chart.ChartTitle;
        Aspose.Slides.Charts.Legend legend = (Aspose.Slides.Charts.Legend)chart.Legend;

        // Output legend overview
        Console.WriteLine("Legend Position: " + legend.Position);
        Console.WriteLine("Legend Overlay: " + legend.Overlay);
        Console.WriteLine("Legend X (fraction of chart width): " + legend.X);
        Console.WriteLine("Legend Y (fraction of chart height): " + legend.Y);
        Console.WriteLine("Legend Width (fraction of chart width): " + legend.Width);
        Console.WriteLine("Legend Height (fraction of chart height): " + legend.Height);
        Console.WriteLine("Legend Text Font Height: " + legend.TextFormat.PortionFormat.FontHeight);

        // Save the presentation
        pres.Save("ChartLegendOverview.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}