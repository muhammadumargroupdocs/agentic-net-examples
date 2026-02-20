using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Define fallback font rules (Unicode range 0x400-0x4FF uses Times New Roman)
            Aspose.Slides.IFontFallBackRulesCollection fallbackRules = new Aspose.Slides.FontFallBackRulesCollection();
            fallbackRules.Add(new Aspose.Slides.FontFallBackRule(0x400, 0x4FF, "Times New Roman"));

            // Assign the fallback rules to the presentation's FontsManager
            presentation.FontsManager.FontFallBackRulesCollection = fallbackRules;

            // Render the first slide to an image
            Aspose.Slides.IImage slideImage = presentation.Slides[0].GetImage(1f, 1f);

            // Save the rendered image as PNG
            string imagePath = "slide.png";
            slideImage.Save(imagePath, Aspose.Slides.ImageFormat.Png);

            // Save the presentation to a file
            string presentationPath = "output.pptx";
            presentation.Save(presentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}