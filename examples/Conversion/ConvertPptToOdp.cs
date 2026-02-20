using System;

class Program
{
    static void Main()
    {
        // Path to the source PPT file
        string inputPath = "input.ppt";
        // Path for the converted ODP file
        string outputPath = "output.odp";

        // Load the presentation from the PPT file
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Save the presentation in ODP format
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Odp);
        // Release resources
        pres.Dispose();
    }
}