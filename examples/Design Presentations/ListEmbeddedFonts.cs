using System;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";
        // Path where the presentation will be saved after listing fonts
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Retrieve embedded fonts
        Aspose.Slides.IFontData[] embeddedFonts = presentation.FontsManager.GetEmbeddedFonts();

        // List embedded font names
        Console.WriteLine("Embedded fonts in the presentation:");
        foreach (Aspose.Slides.IFontData font in embeddedFonts)
        {
            Console.WriteLine(font.FontName);
        }

        // Save the presentation before exiting
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}