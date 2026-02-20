using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Define a fallback rule for Unicode range 0x400-0x4FF to use Times New Roman
        Aspose.Slides.IFontFallBackRulesCollection fallbackRules = new Aspose.Slides.FontFallBackRulesCollection();
        fallbackRules.Add(new Aspose.Slides.FontFallBackRule(0x400, 0x4FF, "Times New Roman"));
        presentation.FontsManager.FontFallBackRulesCollection = fallbackRules;

        // Add a shape with Cyrillic text (falls within the defined range)
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
        shape.AddTextFrame("Пример текста");

        // Render the first slide to an image
        Aspose.Slides.IImage image = presentation.Slides[0].GetImage(1f, 1f);
        string outputImagePath = "output.png";
        image.Save(outputImagePath, Aspose.Slides.ImageFormat.Png);

        // Save the presentation
        string outputPresentationPath = "output.pptx";
        presentation.Save(outputPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        presentation.Dispose();
    }
}