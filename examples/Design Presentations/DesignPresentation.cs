using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Retrieve all fonts used in the presentation and the fonts already embedded
        Aspose.Slides.IFontData[] allFonts = presentation.FontsManager.GetFonts();
        Aspose.Slides.IFontData[] embeddedFonts = presentation.FontsManager.GetEmbeddedFonts();

        // Embed fonts that are not already embedded
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