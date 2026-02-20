using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get slide size (width and height in points)
        SizeF slideSize = presentation.SlideSize.Size;
        Console.WriteLine("Slide width: " + slideSize.Width);
        Console.WriteLine("Slide height: " + slideSize.Height);

        // Save the presentation before exiting
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}