using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "input.pptx");
        // Output PPT file path
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "output.ppt");

        // Load the PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Dispose the presentation object
        presentation.Dispose();
    }
}