using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace CustomFontPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the folder containing custom fonts
            string fontsFolder = @"C:\CustomFonts";
            // Load custom fonts before creating any presentation objects
            Aspose.Slides.FontsLoader.LoadExternalFonts(new string[] { fontsFolder });

            // Create a new presentation
            Presentation pres = new Presentation();

            // Access the first (default) slide
            ISlide slide = pres.Slides[0];

            // Add a rectangle shape with a text frame
            IAutoShape shape = slide.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 400, 100);
            shape.AddTextFrame("Hello with custom font");

            // Set the custom font for the text
            shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.LatinFont = new FontData("MyCustomFont");

            // Save the presentation
            string outputPath = "CustomFontPresentation.pptx";
            pres.Save(outputPath, SaveFormat.Pptx);

            // Clear the loaded custom fonts cache
            Aspose.Slides.FontsLoader.ClearCache();

            // Dispose the presentation
            pres.Dispose();
        }
    }
}