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

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a Pie chart to the slide (x, y, width, height)
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Pie, 50f, 50f, 500f, 400f);

        // Customize data label settings for the first series
        // Show leader lines for all data labels in the series
        chart.ChartData.Series[0].Labels.DefaultDataLabelFormat.ShowLeaderLines = true;

        // Show value for the first data label
        chart.ChartData.Series[0].Labels[0].DataLabelFormat.ShowValue = true;

        // Show category name for the first data label
        chart.ChartData.Series[0].Labels[0].DataLabelFormat.ShowCategoryName = true;

        // Set a custom separator for the first data label
        chart.ChartData.Series[0].Labels[0].DataLabelFormat.Separator = "; ";

        // Save the presentation
        presentation.Save("FormattedDataLabels.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}