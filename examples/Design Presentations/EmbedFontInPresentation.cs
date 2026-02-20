using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define file paths
        string presentationPath = "output.pptx";
        string fontPath = "MyFont.ttf";

        // Create a new presentation
        Presentation presentation = new Presentation();

        // Load the TrueType font bytes
        byte[] fontBytes = File.ReadAllBytes(fontPath);

        // Embed the font with all characters
        presentation.FontsManager.AddEmbeddedFont(fontBytes, Aspose.Slides.Export.EmbedFontCharacters.All);

        // Save the presentation
        presentation.Save(presentationPath, SaveFormat.Pptx);

        // Clean up
        presentation.Dispose();
    }
}