namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Create a collection for font fallback rules
            Aspose.Slides.IFontFallBackRulesCollection rules = new Aspose.Slides.FontFallBackRulesCollection();

            // Add a fallback rule for Unicode range 0x400-0x4FF using Times New Roman
            Aspose.Slides.FontFallBackRule fallbackRule = new Aspose.Slides.FontFallBackRule(0x400, 0x4FF, "Times New Roman");
            rules.Add(fallbackRule);

            // Assign the fallback rules to the presentation's FontsManager
            pres.FontsManager.FontFallBackRulesCollection = rules;

            // Render the first slide to an image
            Aspose.Slides.IImage img = pres.Slides[0].GetImage(1f, 1f);
            // Save the rendered image as PNG
            img.Save("slide.png", Aspose.Slides.ImageFormat.Png);
            img.Dispose();

            // Save the presentation
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}