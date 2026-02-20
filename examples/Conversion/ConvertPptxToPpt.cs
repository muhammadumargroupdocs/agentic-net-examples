using System;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string inputPath = "example.pptx";
        string outputPath = "example_converted.ppt";

        // Load the PPTX presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation in PPT format
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Release resources
        pres.Dispose();
    }
}