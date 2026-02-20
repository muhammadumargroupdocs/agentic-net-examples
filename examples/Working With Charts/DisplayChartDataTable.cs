using System;

class Program
{
    static void Main(string[] args)
    {
        // Output file path
        string outputPath = "DisplayChartDataTable.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50f, 50f, 600f, 400f);

        // Enable the data table for the chart
        chart.HasDataTable = true;

        // Optional: customize the data table appearance
        Aspose.Slides.Charts.IDataTable dataTable = chart.ChartDataTable;
        dataTable.HasBorderHorizontal = true;
        dataTable.HasBorderVertical = true;
        dataTable.HasBorderOutline = true;
        dataTable.ShowLegendKey = false;

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}