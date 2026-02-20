using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Create fallback rules collection
        Aspose.Slides.IFontFallBackRulesCollection rules = new Aspose.Slides.FontFallBackRulesCollection();

        // Add Cyrillic range fallback to Arial
        rules.Add(new Aspose.Slides.FontFallBackRule(0x400, 0x4FF, "Arial"));

        // Add Arabic range fallback to Times New Roman
        rules.Add(new Aspose.Slides.FontFallBackRule(0x0600, 0x06FF, "Times New Roman"));

        // Define emoji fallback fonts
        string[] emojiFonts = new string[] { "Segoe UI Emoji", "Noto Color Emoji" };
        // Add Emoji range fallback using the emoji fonts array
        rules.Add(new Aspose.Slides.FontFallBackRule(0x1F600, 0x1F64F, emojiFonts));

        // Assign the fallback rules to the presentation
        presentation.FontsManager.FontFallBackRulesCollection = rules;

        // Save the presentation
        presentation.Save("FallbackPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}