using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace CustomFontDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load external font before creating any presentation objects
            string fontPath = "customfont.ttf";
            byte[] fontData = File.ReadAllBytes(fontPath);
            FontsLoader.LoadExternalFont(fontData);

            // Create a new presentation
            Presentation pres = new Presentation();

            // Add a new slide based on the layout of the first slide
            ISlide slide = pres.Slides.AddEmptySlide(pres.Slides[0].LayoutSlide);

            // Add a rectangle auto shape and a text frame
            IAutoShape autoShape = (IAutoShape)slide.Shapes.AddAutoShape(
                ShapeType.Rectangle, 100, 100, 400, 100);
            autoShape.AddTextFrame("Sample text using custom font");

            // Apply the loaded custom font to all portions in the paragraph
            IParagraph paragraph = autoShape.TextFrame.Paragraphs[0];
            foreach (IPortion portion in paragraph.Portions)
            {
                portion.PortionFormat.LatinFont = new FontData("CustomFontName");
            }

            // Save the presentation
            pres.Save("output.pptx", SaveFormat.Pptx);

            // Clear the loaded fonts cache
            FontsLoader.ClearCache();

            // Dispose the presentation
            pres.Dispose();
        }
    }
}