using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace FontEmbeddingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output presentation files
            System.String inputPath = "input.pptx";
            System.String outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Get all fonts used in the presentation
            Aspose.Slides.IFontData[] allFonts = presentation.FontsManager.GetFonts();

            // Get fonts that are already embedded
            Aspose.Slides.IFontData[] embeddedFonts = presentation.FontsManager.GetEmbeddedFonts();

            // Iterate through each font and embed it if not already embedded
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
                    // Embed the entire font (all characters)
                    presentation.FontsManager.AddEmbeddedFont(font, Aspose.Slides.Export.EmbedFontCharacters.All);
                }
            }

            // Save the presentation with embedded fonts
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up resources
            presentation.Dispose();
        }
    }
}