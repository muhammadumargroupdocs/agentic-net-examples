using System;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";
        // Path for the resulting TIFF file
        string outputPath = "output.tiff";

        // Load the presentation from the specified file
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Save the presentation as a multi‑page TIFF image
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff);
        }
    }
}