using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Retrieve all fonts used in the presentation
        Aspose.Slides.IFontData[] allFonts = presentation.FontsManager.GetFonts();

        // Retrieve fonts that are already embedded
        Aspose.Slides.IFontData[] embeddedFonts = presentation.FontsManager.GetEmbeddedFonts();

        // List embedded fonts
        Console.WriteLine("Embedded fonts in the presentation:");
        foreach (Aspose.Slides.IFontData ef in embeddedFonts)
        {
            Console.WriteLine("- " + ef.FontName);
        }

        // Embed missing fonts (optional demonstration)
        foreach (Aspose.Slides.IFontData font in allFonts)
        {
            bool isEmbedded = false;
            foreach (Aspose.Slides.IFontData ef in embeddedFonts)
            {
                if (ef.Equals(font))
                {
                    isEmbedded = true;
                    break;
                }
            }
            if (!isEmbedded)
            {
                presentation.FontsManager.AddEmbeddedFont(font, Aspose.Slides.Export.EmbedFontCharacters.All);
            }
        }

        // Save the presentation before exiting
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation object
        presentation.Dispose();
    }
}