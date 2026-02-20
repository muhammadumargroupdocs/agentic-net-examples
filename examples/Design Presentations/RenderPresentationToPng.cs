using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputImagePath = "slide1.png";
        string outputPresentationPath = "output.pptx";

        // Create a collection of font fallback rules
        Aspose.Slides.IFontFallBackRulesCollection rules = new Aspose.Slides.FontFallBackRulesCollection();
        // Add a rule for Cyrillic range using Times New Roman
        rules.Add(new Aspose.Slides.FontFallBackRule(0x400, 0x4FF, "Times New Roman"));
        // Add a rule for emoji range using multiple fallback fonts
        string[] emojiFonts = new string[] { "Segoe UI Emoji", "Apple Color Emoji", "Noto Color Emoji" };
        rules.Add(new Aspose.Slides.FontFallBackRule(0x1F600, 0x1F64F, emojiFonts));

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);
        // Assign the fallback rules to the presentation's FontsManager
        pres.FontsManager.FontFallBackRulesCollection = rules;

        // Render the first slide to a PNG image
        Aspose.Slides.IImage img = pres.Slides[0].GetImage(1f, 1f);
        img.Save(outputImagePath, Aspose.Slides.ImageFormat.Png);
        img.Dispose();

        // Save the presentation before exiting
        pres.Save(outputPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}