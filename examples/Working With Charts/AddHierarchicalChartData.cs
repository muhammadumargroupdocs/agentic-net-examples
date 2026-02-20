using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a Sunburst chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(Aspose.Slides.Charts.ChartType.Sunburst, 50f, 50f, 600f, 400f);

        // Access the data points of the first series
        Aspose.Slides.Charts.IChartDataPointCollection dataPoints = chart.ChartData.Series[0].DataPoints;

        // Show value for a specific data point level
        dataPoints[3].DataPointLevels[0].Label.DataLabelFormat.ShowValue = true;

        // Configure label for a branch
        Aspose.Slides.Charts.IDataLabel branch1Label = dataPoints[0].DataPointLevels[2].Label;
        branch1Label.DataLabelFormat.ShowCategoryName = true;
        branch1Label.DataLabelFormat.ShowSeriesName = true;
        branch1Label.DataLabelFormat.TextFormat.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        branch1Label.DataLabelFormat.TextFormat.PortionFormat.FillFormat.SolidFillColor.Color = Color.Yellow;

        // Set fill format for another data point
        Aspose.Slides.Charts.IFormat steam4Format = dataPoints[9].Format;
        steam4Format.Fill.FillType = Aspose.Slides.FillType.Solid;
        steam4Format.Fill.SolidFillColor.Color = Color.FromArgb(255, 0, 0, 255);

        // Save the presentation
        string outputPath = "HierarchicalChart.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}