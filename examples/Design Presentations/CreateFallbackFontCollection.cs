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

        // Add a rule for basic Latin characters to use Arial
        rules.Add(new Aspose.Slides.FontFallBackRule(0x0, 0x7F, "Arial"));

        // Add a rule for Cyrillic characters to use Times New Roman
        rules.Add(new Aspose.Slides.FontFallBackRule(0x400, 0x4FF, "Times New Roman"));

        // Define emoji fallback fonts
        string[] emojiFonts = new string[] { "Segoe UI Emoji", "Apple Color Emoji" };
        // Add a rule for emoji Unicode range
        rules.Add(new Aspose.Slides.FontFallBackRule(0x1F600, 0x1F64F, emojiFonts));

        // Assign the fallback rules collection to the presentation
        presentation.FontsManager.FontFallBackRulesCollection = rules;

        // Save the presentation
        presentation.Save("FallbackFontsPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}