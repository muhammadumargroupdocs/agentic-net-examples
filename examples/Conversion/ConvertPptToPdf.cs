using System;

class Program
{
    static void Main()
    {
        // Path to the source PPT/PPTX file
        string inputPath = "input.pptx";
        // Path where the PDF will be saved
        string outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Convert and save as PDF
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
        // Ensure resources are released
        pres.Dispose();
    }
}