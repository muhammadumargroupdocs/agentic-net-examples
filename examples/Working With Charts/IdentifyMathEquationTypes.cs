using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace ChartMathEquationIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Iterate through all slides
            for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[slideIndex];

                // Iterate through all shapes on the slide
                for (int shapeIndex = 0; shapeIndex < slide.Shapes.Count; shapeIndex++)
                {
                    // Check if the shape is a chart
                    if (slide.Shapes[shapeIndex] is Aspose.Slides.Charts.IChart)
                    {
                        Aspose.Slides.Charts.IChart chart = (Aspose.Slides.Charts.IChart)slide.Shapes[shapeIndex];
                        Aspose.Slides.Charts.ChartType chartType = chart.Type;

                        // Identify supported math equation related capabilities using ChartTypeCharacterizer
                        bool is2D = Aspose.Slides.Charts.ChartTypeCharacterizer.Is2DChart(chartType);
                        bool is3D = Aspose.Slides.Charts.ChartTypeCharacterizer.Is3DChart(chartType);
                        bool isBar = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeBar(chartType);
                        bool isLine = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeLine(chartType);
                        bool isPie = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypePie(chartType);
                        bool isScatter = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeScatter(chartType);
                        bool isBubble = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeBubble(chartType);
                        bool isRadar = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeRadar(chartType);
                        bool isSurface = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeSurface(chartType);
                        bool isDoughnut = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeDoughnut(chartType);
                        bool isArea = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeArea(chartType);
                        bool isStock = Aspose.Slides.Charts.ChartTypeCharacterizer.IsChartTypeStock(chartType);

                        // Output the identified capabilities
                        Console.WriteLine($"Slide {slideIndex + 1}, Shape {shapeIndex + 1}: Chart Type = {chartType}");
                        Console.WriteLine($"  2D Chart: {is2D}");
                        Console.WriteLine($"  3D Chart: {is3D}");
                        Console.WriteLine($"  Bar Chart: {isBar}");
                        Console.WriteLine($"  Line Chart: {isLine}");
                        Console.WriteLine($"  Pie Chart: {isPie}");
                        Console.WriteLine($"  Scatter Chart: {isScatter}");
                        Console.WriteLine($"  Bubble Chart: {isBubble}");
                        Console.WriteLine($"  Radar Chart: {isRadar}");
                        Console.WriteLine($"  Surface Chart: {isSurface}");
                        Console.WriteLine($"  Doughnut Chart: {isDoughnut}");
                        Console.WriteLine($"  Area Chart: {isArea}");
                        Console.WriteLine($"  Stock Chart: {isStock}");
                        Console.WriteLine();
                    }
                }
            }

            // Save the presentation before exiting
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}