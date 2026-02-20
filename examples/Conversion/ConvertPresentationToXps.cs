using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";
        // Path for the output XPS file
        string outputPath = "output.xps";

        // Load the presentation from the file
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation to XPS format using default settings
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Xps);

        // Release resources
        pres.Dispose();
    }
}