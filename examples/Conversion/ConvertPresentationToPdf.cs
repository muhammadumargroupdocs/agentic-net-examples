using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPT file
        string inputPath = "input.ppt";
        // Path to the destination PDF file
        string outputPath = "output.pdf";

        // Load the PPT presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Save the presentation as PDF
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
        }
    }
}