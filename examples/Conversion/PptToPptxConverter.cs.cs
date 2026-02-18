using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the source PPT file
        string inputPath = "input.ppt";

        // Path for the converted PPTX file
        string outputPath = "output.pptx";

        // Load the PPT presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation in PPTX format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}