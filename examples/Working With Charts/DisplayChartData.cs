using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a line chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Line, 50, 50, 450, 300);

        // Enable the data table for the chart
        chart.HasDataTable = true;

        // Set number format with precision for the series values
        chart.ChartData.Series[0].NumberFormatOfValues = "#,##0.00";

        // Configure data labels to show value, percentage and category name
        chart.ChartData.Series[0].Labels.DefaultDataLabelFormat.ShowValue = true;
        chart.ChartData.Series[0].Labels.DefaultDataLabelFormat.ShowPercentage = true;
        chart.ChartData.Series[0].Labels.DefaultDataLabelFormat.ShowCategoryName = true;

        // Save the presentation
        presentation.Save("DisplayChartData.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}