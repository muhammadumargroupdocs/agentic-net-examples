using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Access the first slide (index 0)
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a doughnut chart to the slide at position (50,50) with size 400x400
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.Doughnut, 50, 50, 400, 400);

        // Set the doughnut hole size to 50% of the plot area
        chart.ChartData.Series[0].ParentSeriesGroup.DoughnutHoleSize = (byte)50;

        // Save the presentation to a PPTX file
        pres.Save("DoughnutChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}