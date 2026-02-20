using System;

class Program
{
    static void Main(string[] args)
    {
        // Input PowerPoint file containing math equations
        string inputPath = "input.pptx";
        // Output PDF file
        string outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save the presentation as PDF (math equations are preserved)
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
    }
}