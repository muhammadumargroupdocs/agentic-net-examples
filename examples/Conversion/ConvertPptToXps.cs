using System;

class Program
{
    static void Main()
    {
        // Input PPT file path
        System.String inputPath = "example.pptx";
        // Output XPS file path
        System.String outputPath = "example.xps";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as XPS
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Xps);

        // Dispose the presentation object
        pres.Dispose();
    }
}