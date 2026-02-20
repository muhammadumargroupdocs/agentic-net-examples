using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output presentation paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Path to the custom font file
        string fontPath = "customfont.ttf";

        // Load the font file into a byte array
        byte[] fontData = File.ReadAllBytes(fontPath);

        // Register the external font so it can be used by the presentation
        Aspose.Slides.FontsLoader.LoadExternalFont(fontData);

        // Load the existing presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Embed the loaded font into the presentation (embed all characters)
        presentation.FontsManager.AddEmbeddedFont(fontData, Aspose.Slides.Export.EmbedFontCharacters.All);

        // Save the presentation with the embedded font
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}