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

        // Add a chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 600f, 400f);

        // Enable the data table for the chart
        chart.HasDataTable = true;

        // Format the data table
        Aspose.Slides.Charts.IDataTable dataTable = chart.ChartDataTable;
        dataTable.HasBorderHorizontal = true;
        dataTable.HasBorderVertical = true;
        dataTable.HasBorderOutline = true;
        dataTable.ShowLegendKey = false;

        // Save the presentation
        string outputPath = "DataTableFormatting.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}