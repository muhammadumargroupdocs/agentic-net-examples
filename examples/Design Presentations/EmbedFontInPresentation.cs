using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load custom TrueType font before creating any presentation objects
        byte[] customFontBytes = File.ReadAllBytes("custom.ttf");
        Aspose.Slides.FontsLoader.LoadExternalFont(customFontBytes);

        // Input and output presentation files
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Create presentation instance
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Retrieve all fonts used in the presentation
        Aspose.Slides.IFontData[] allFonts = presentation.FontsManager.GetFonts();

        // Retrieve fonts already embedded in the presentation
        Aspose.Slides.IFontData[] embeddedFonts = presentation.FontsManager.GetEmbeddedFonts();

        // Embed any fonts that are not already embedded
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

        // Save the presentation with embedded fonts
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}