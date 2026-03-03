using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string inputFile = "input.pptx";
        // Path for the converted PPT file
        string outputFile = "output.ppt";

        // Load the PPTX presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile);

        // Save the presentation in PPT format
        pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Ppt);

        // Release resources
        pres.Dispose();
    }
}