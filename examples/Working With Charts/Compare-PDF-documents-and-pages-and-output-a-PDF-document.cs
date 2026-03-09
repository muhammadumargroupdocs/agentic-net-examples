using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paths to the input and output presentations
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the existing presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Get the first shape on the first slide and cast it to a chart
            Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes[0] as Aspose.Slides.Charts.IChart;

            if (chart != null)
            {
                // Change the horizontal axis to a date axis
                chart.Axes.HorizontalAxis.CategoryAxisType = Aspose.Slides.Charts.CategoryAxisType.Date;

                // Set the major unit to 1 month
                chart.Axes.HorizontalAxis.IsAutomaticMajorUnit = false;
                chart.Axes.HorizontalAxis.MajorUnit = 1.0;
                chart.Axes.HorizontalAxis.MajorUnitScale = Aspose.Slides.Charts.TimeUnitType.Months;
            }

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}