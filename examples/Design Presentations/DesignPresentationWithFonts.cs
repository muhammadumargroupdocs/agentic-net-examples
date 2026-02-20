using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths to input presentation and output file
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Font folders and font files
        string fontFolder1 = @"C:\Fonts";
        string fontFolder2 = @"D:\MoreFonts";
        string fontPath1 = @"C:\Fonts\CustomFont1.ttf";
        string fontPath2 = @"C:\Fonts\CustomFont2.ttf";

        // Load font data into memory
        byte[] fontData1 = File.ReadAllBytes(fontPath1);
        byte[] fontData2 = File.ReadAllBytes(fontPath2);

        // Create LoadOptions and specify font sources
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.DocumentLevelFontSources.FontFolders = new string[] { fontFolder1, fontFolder2 };
        loadOptions.DocumentLevelFontSources.MemoryFonts = new byte[][] { fontData1, fontData2 };

        // Load presentation with custom font sources
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath, loadOptions);

        // Add any missing fonts as embedded fonts
        Aspose.Slides.IFontData[] allFonts = pres.FontsManager.GetFonts();
        Aspose.Slides.IFontData[] embeddedFonts = pres.FontsManager.GetEmbeddedFonts();
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
                pres.FontsManager.AddEmbeddedFont(font, Aspose.Slides.Export.EmbedFontCharacters.All);
            }
        }

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}