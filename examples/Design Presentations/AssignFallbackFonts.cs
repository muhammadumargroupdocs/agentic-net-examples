using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Create a collection to hold fallback rules
        Aspose.Slides.IFontFallBackRulesCollection rules = new Aspose.Slides.FontFallBackRulesCollection();

        // Rule for Basic Latin characters (U+0000 to U+007F) with fallback font "Arial"
        rules.Add(new Aspose.Slides.FontFallBackRule(0x0000u, 0x007Fu, "Arial"));

        // Rule for Cyrillic characters (U+0400 to U+04FF) with primary fallback "Arial" and additional fallback "Times New Roman"
        Aspose.Slides.FontFallBackRule cyrillicRule = new Aspose.Slides.FontFallBackRule(0x0400u, 0x04FFu, "Arial");
        cyrillicRule.AddFallBackFonts("Times New Roman");
        rules.Add(cyrillicRule);

        // Rule for Emoji characters (U+1F600 to U+1F64F) with multiple fallback fonts
        string[] emojiFonts = new string[] { "Segoe UI Emoji", "Apple Color Emoji", "Noto Color Emoji" };
        rules.Add(new Aspose.Slides.FontFallBackRule(0x1F600u, 0x1F64Fu, emojiFonts));

        // Assign the fallback rules collection to the presentation's FontsManager
        pres.FontsManager.FontFallBackRulesCollection = rules;

        // Save the presentation before exiting
        pres.Save("FallbackFontsPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        pres.Dispose();
    }
}