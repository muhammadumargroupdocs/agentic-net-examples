using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace AxesDemo
{
    class Program
    {
        static void Main()
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a clustered column chart to the first slide
            Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 450, 300);

            // Set the horizontal axis to be positioned between categories
            chart.Axes.HorizontalAxis.AxisBetweenCategories = true;

            // Save the presentation
            presentation.Save("AxesDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}