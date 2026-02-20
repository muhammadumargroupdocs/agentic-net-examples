using System;

class Program
{
    static void Main()
    {
        // Path to the input PPTX file
        var inputPath = "input.pptx";
        // Path for the output PPTX file after inspection
        var outputPath = "output_inspected.pptx";

        // Load the presentation from the file
        var presentation = new Aspose.Slides.Presentation(inputPath);

        // Access document properties
        var docProps = presentation.DocumentProperties;
        Console.WriteLine("Title: " + docProps.Title);
        Console.WriteLine("Author: " + docProps.Author);
        Console.WriteLine("Number of slides: " + presentation.Slides.Count);

        // Iterate through each slide
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            var slide = presentation.Slides[i];
            Console.WriteLine($"Slide {i + 1} contains {slide.Shapes.Count} shapes.");

            // Iterate through each shape on the slide
            foreach (var shape in slide.Shapes)
            {
                Console.WriteLine($"Shape type: {shape.GetType().Name}");

                // If the shape is a chart, inspect its data
                if (shape is Aspose.Slides.Charts.IChart chart)
                {
                    Console.WriteLine($"Chart type: {chart.Type}");

                    var seriesCollection = chart.ChartData.Series;
                    foreach (Aspose.Slides.Charts.ChartSeries series in seriesCollection)
                    {
                        Console.WriteLine($"Series name: {series.Name}");

                        foreach (Aspose.Slides.Charts.IChartDataPoint point in series.DataPoints)
                        {
                            // Retrieve the numeric value of the data point
                            var cellValue = point.Value.AsCell.Value;
                            Console.WriteLine($"Data point value: {cellValue}");
                        }
                    }
                }
            }
        }

        // Save the (potentially unchanged) presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}