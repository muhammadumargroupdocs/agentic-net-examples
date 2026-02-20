using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a pie chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Pie, // Chart type
            50f,   // X position
            50f,   // Y position
            500f,  // Width
            400f   // Height
        );

        // Enable value display for data labels
        chart.ChartData.Series[0].Labels.DefaultDataLabelFormat.ShowValue = true;

        // Show data labels as callouts
        chart.ChartData.Series[0].Labels.DefaultDataLabelFormat.ShowLabelAsDataCallout = true;

        // Show leader lines for the callouts
        chart.ChartData.Series[0].Labels.DefaultDataLabelFormat.ShowLeaderLines = true;

        // Save the presentation
        presentation.Save("CustomCallout.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}