using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Create a collection for fallback font rules
            Aspose.Slides.IFontFallBackRulesCollection rules = new Aspose.Slides.FontFallBackRulesCollection();

            // Latin range fallback to Arial
            Aspose.Slides.FontFallBackRule latinRule = new Aspose.Slides.FontFallBackRule(0x0000u, 0x007Fu, "Arial");
            rules.Add(latinRule);

            // Cyrillic range fallback to Times New Roman
            Aspose.Slides.FontFallBackRule cyrillicRule = new Aspose.Slides.FontFallBackRule(0x0400u, 0x04FFu, "Times New Roman");
            rules.Add(cyrillicRule);

            // Emoji range fallback to multiple fonts
            string[] emojiFonts = new string[] { "Segoe UI Emoji", "Apple Color Emoji", "Noto Color Emoji" };
            Aspose.Slides.FontFallBackRule emojiRule = new Aspose.Slides.FontFallBackRule(0x1F600u, 0x1F64Fu, emojiFonts);
            rules.Add(emojiRule);

            // Assign the fallback rules collection to the presentation
            pres.FontsManager.FontFallBackRulesCollection = rules;

            // Save the presentation
            pres.Save("FallbackFontsPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up
            pres.Dispose();
        }
    }
}