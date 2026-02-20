using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source presentation
        System.String inputPath = "input.pptx";
        // Path where the modified presentation will be saved
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Define the font to be replaced (source) and the replacement font (destination)
        Aspose.Slides.IFontData sourceFont = new Aspose.Slides.FontData("Arial");
        Aspose.Slides.IFontData destFont = new Aspose.Slides.FontData("Times New Roman");

        // Replace the source font with the destination font throughout the presentation
        presentation.FontsManager.ReplaceFont(sourceFont, destFont);

        // Save the updated presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}