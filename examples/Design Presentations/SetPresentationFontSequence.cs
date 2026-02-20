using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle AutoShape with a text frame
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
        shape.AddTextFrame("Sample text with custom fonts");

        // Set font properties for the first paragraph and portion
        shape.TextFrame.Paragraphs[0].ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Center;
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 24f;
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FillFormat.SolidFillColor.Color =
            Color.FromArgb(255, 0, 0, 255); // Blue color

        // Define font fallback rules
        Aspose.Slides.IFontFallBackRulesCollection fallbackRules =
            new Aspose.Slides.FontFallBackRulesCollection();
        fallbackRules.Add(new Aspose.Slides.FontFallBackRule(0x400, 0x4FF, "Times New Roman"));
        string[] emojiFonts = new string[] { "Segoe UI Emoji", "Apple Color Emoji", "Noto Color Emoji" };
        fallbackRules.Add(new Aspose.Slides.FontFallBackRule(0x1F600, 0x1F64F, emojiFonts));

        // Apply fallback rules to the presentation
        pres.FontsManager.FontFallBackRulesCollection = fallbackRules;

        // Save the presentation
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}