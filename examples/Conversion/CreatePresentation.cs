using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Path to the source presentation file
        string inputPath = "input.pptx";
        // Path where the presentation will be saved
        string outputPath = "output.pptx";

        // Load the presentation from the specified file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation to the output file in PPTX format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}