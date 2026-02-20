using System;

class Program
{
    static void Main(string[] args)
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Iterate through slides
        int slideIndex = 0;
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            slideIndex++;
            Console.WriteLine($"Slide {slideIndex} contains {slide.Shapes.Count} shapes.");
        }

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}