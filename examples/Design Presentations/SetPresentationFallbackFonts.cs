using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Create a collection for font fallback rules
        Aspose.Slides.IFontFallBackRulesCollection rules = new Aspose.Slides.FontFallBackRulesCollection();

        // Add a fallback rule for Unicode range 0x400-0x4FF with primary font "Times New Roman"
        Aspose.Slides.IFontFallBackRule rule1 = new Aspose.Slides.FontFallBackRule(0x400u, 0x4FFu, "Times New Roman");
        // Add additional fallback fonts
        rule1.AddFallBackFonts(new string[] { "Arial", "Calibri" });
        rules.Add(rule1);

        // Assign the fallback rules collection to the presentation
        pres.FontsManager.FontFallBackRulesCollection = rules;

        // Save the presentation
        pres.Save("FallbackFontsPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}