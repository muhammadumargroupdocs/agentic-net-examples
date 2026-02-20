using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";
        // Path for the converted ODP file
        string outputPath = "output.odp";

        // Load the PPTX presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Convert and save the presentation to ODP format
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Odp);
        // Release resources
        pres.Dispose();
    }
}