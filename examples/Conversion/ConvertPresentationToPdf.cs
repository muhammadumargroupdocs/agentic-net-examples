using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";

        // Path where the PDF will be saved
        string outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as PDF using the rule for saving without additional options
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);

        // Dispose the presentation object
        pres.Dispose();
    }
}