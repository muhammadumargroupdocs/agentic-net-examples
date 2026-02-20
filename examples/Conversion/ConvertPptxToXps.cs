using System;

class Program
{
    static void Main(string[] args)
    {
        // Input PPTX file path
        string inputPath = "example.pptx";
        // Output XPS file path
        string outputPath = "example.xps";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Save the presentation to XPS format
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Xps);
        // Dispose the presentation object
        pres.Dispose();
    }
}