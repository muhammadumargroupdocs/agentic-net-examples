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

        // Add a clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 450, 300);

        // Set the vertical axis display unit to Millions
        chart.Axes.VerticalAxis.DisplayUnit = Aspose.Slides.Charts.DisplayUnitType.Millions;

        // Set the distance of category axis labels from the axis
        chart.Axes.HorizontalAxis.LabelOffset = (ushort)200;

        // Rotate the vertical axis labels by 45 degrees
        chart.Axes.VerticalAxis.HasTitle = true;
        chart.Axes.VerticalAxis.Title.TextFormat.TextBlockFormat.RotationAngle = 45;

        // Save the presentation
        presentation.Save("FormattedAxisLabels.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}