using System;
using System.IO;

namespace LoadTrueTypeFontExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the TrueType font file
            string fontPath = "C:\\Fonts\\MyFont.ttf";

            // Load font bytes
            byte[] fontBytes = System.IO.File.ReadAllBytes(fontPath);

            // Register the external font with Aspose.Slides
            Aspose.Slides.FontsLoader.LoadExternalFont(fontBytes);

            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Add a rectangle shape with a text frame
            Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)pres.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
            shape.AddTextFrame("Sample text with custom font");

            // Access the first portion of the text
            Aspose.Slides.ITextFrame tf = shape.TextFrame;
            Aspose.Slides.IParagraph para = tf.Paragraphs[0];
            Aspose.Slides.IPortion port = para.Portions[0];

            // Apply the loaded TrueType font to the portion
            port.PortionFormat.LatinFont = new Aspose.Slides.FontData("MyFont");
            port.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
            port.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
            port.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            port.PortionFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;

            // Save the presentation
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}