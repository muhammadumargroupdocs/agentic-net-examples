using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PowerPoint file
        string inputPath = "input.pptx";
        // Desired XPS output file
        string outputPath = "output.xps";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Convert and save to XPS format
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Xps);

        // Release resources
        pres.Dispose();
    }
}