using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        string inputPath = "input.pptx";
        // Path where the modified presentation will be saved
        string outputPath = "output.pptx";

        // Load the presentation from the input file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Define the font to be replaced (source) and the new font (destination)
        Aspose.Slides.IFontData sourceFont = new Aspose.Slides.FontData("OldFontName");
        Aspose.Slides.IFontData destFont = new Aspose.Slides.FontData("NewFontName");

        // Replace all occurrences of the source font with the destination font
        presentation.FontsManager.ReplaceFont(sourceFont, destFont);

        // Save the updated presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}