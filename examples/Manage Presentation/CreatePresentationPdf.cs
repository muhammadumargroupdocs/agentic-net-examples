using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Define the output PDF file path
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "presentation.pdf");

        // Create a new presentation instance
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Save the presentation as PDF
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);

        // Release resources
        presentation.Dispose();
    }
}