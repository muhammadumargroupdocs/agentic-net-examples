using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Create a collection for font fallback rules
        Aspose.Slides.IFontFallBackRulesCollection rules = new Aspose.Slides.FontFallBackRulesCollection();

        // Add a fallback rule for Cyrillic characters
        rules.Add(new Aspose.Slides.FontFallBackRule(0x400u, 0x4FFu, "Times New Roman"));

        // Add a fallback rule for basic emoji range
        rules.Add(new Aspose.Slides.FontFallBackRule(0x1F600u, 0x1F64Fu, "Segoe UI Emoji"));

        // Add a fallback rule with multiple emoji fonts for a broader range
        string[] emojiFonts = new string[] { "Apple Color Emoji", "Segoe UI Emoji", "Noto Color Emoji" };
        rules.Add(new Aspose.Slides.FontFallBackRule(0x1F300u, 0x1F5FFu, emojiFonts));

        // Assign the fallback rules collection to the presentation's FontsManager
        presentation.FontsManager.FontFallBackRulesCollection = rules;

        // Save the presentation to a file
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        presentation.Dispose();
    }
}