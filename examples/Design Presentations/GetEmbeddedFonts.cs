using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";
        // Path where the presentation will be saved after processing
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Retrieve all fonts used in the presentation
        Aspose.Slides.IFontData[] allFonts = presentation.FontsManager.GetFonts();
        // Retrieve only the fonts that are already embedded
        Aspose.Slides.IFontData[] embeddedFonts = presentation.FontsManager.GetEmbeddedFonts();

        // List the embedded fonts
        Console.WriteLine("Embedded fonts in the presentation:");
        foreach (Aspose.Slides.IFontData font in embeddedFonts)
        {
            // Assuming IFontData provides a FontName property; otherwise, use ToString()
            Console.WriteLine(font.FontName);
        }

        // Save the presentation (required by authoring rules)
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        // Dispose the presentation object
        presentation.Dispose();
    }
}