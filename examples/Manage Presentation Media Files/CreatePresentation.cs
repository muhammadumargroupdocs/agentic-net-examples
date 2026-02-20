using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation (PPTX)
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Define output file path
        string outputPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "output.pptx");

        // Save the presentation before exiting
        presentation.Save(outputPath, SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}