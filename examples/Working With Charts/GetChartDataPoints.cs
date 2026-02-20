using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a Sunburst chart on the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Sunburst, 50, 50, 500, 400);

        // Access the data points collection of the first series
        Aspose.Slides.Charts.IChartDataPointCollection dataPoints = chart.ChartData.Series[0].DataPoints;

        // Show the value for the fourth data point (index 3)
        dataPoints[3].DataPointLevels[0].Label.DataLabelFormat.ShowValue = true;

        // Customize the label of the first data point's third level
        Aspose.Slides.Charts.IDataLabel branch1Label = dataPoints[0].DataPointLevels[2].Label;
        branch1Label.DataLabelFormat.ShowCategoryName = true;
        branch1Label.DataLabelFormat.ShowSeriesName = true;
        branch1Label.DataLabelFormat.TextFormat.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        branch1Label.DataLabelFormat.TextFormat.PortionFormat.FillFormat.SolidFillColor.Color = Color.Yellow;

        // Change the fill color of the tenth data point (index 9)
        Aspose.Slides.Charts.IFormat steam4Format = dataPoints[9].Format;
        steam4Format.Fill.FillType = Aspose.Slides.FillType.Solid;
        steam4Format.Fill.SolidFillColor.Color = Color.FromArgb(255, 0, 128, 255);

        // Save the presentation
        presentation.Save("DataPointsDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}