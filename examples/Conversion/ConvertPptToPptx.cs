using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPT file
        string inputPath = "input.ppt";
        // Path for the converted PPTX file
        string outputPath = "output.pptx";

        // Load the PPT presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Save the presentation in PPTX format
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        // Release resources
        pres.Dispose();
    }
}