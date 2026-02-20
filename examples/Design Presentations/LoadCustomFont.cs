using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the folder that contains custom fonts
        System.String fontsFolder = @"C:\CustomFonts";

        // Load custom fonts before creating any presentation objects
        Aspose.Slides.FontsLoader.LoadExternalFonts(new System.String[] { fontsFolder });

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Save the presentation to a file
        System.String outputPath = @"C:\Output\CustomFontPresentation.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clear the loaded custom fonts cache
        Aspose.Slides.FontsLoader.ClearCache();

        // Dispose the presentation object
        presentation.Dispose();
    }
}