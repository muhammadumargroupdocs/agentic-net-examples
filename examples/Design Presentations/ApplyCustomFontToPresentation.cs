using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load custom font from a folder containing the font file
        string fontFolder = System.IO.Path.GetDirectoryName("MyCustomFont.ttf");
        Aspose.Slides.FontsLoader.LoadExternalFonts(new string[] { fontFolder });

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide (created by default)
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add two rectangles with text
        Aspose.Slides.IAutoShape shape1 = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
        shape1.AddTextFrame("Custom Font Text 1");
        Aspose.Slides.IAutoShape shape2 = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 200, 400, 100);
        shape2.AddTextFrame("Custom Font Text 2");

        // Access text frames and portions
        Aspose.Slides.ITextFrame tf1 = shape1.TextFrame;
        Aspose.Slides.ITextFrame tf2 = shape2.TextFrame;
        Aspose.Slides.IParagraph para1 = tf1.Paragraphs[0];
        Aspose.Slides.IParagraph para2 = tf2.Paragraphs[0];
        Aspose.Slides.IPortion port1 = para1.Portions[0];
        Aspose.Slides.IPortion port2 = para2.Portions[0];

        // Apply custom font and formatting
        port1.PortionFormat.LatinFont = new Aspose.Slides.FontData("MyCustomFont");
        port2.PortionFormat.LatinFont = new Aspose.Slides.FontData("MyCustomFont");
        port1.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        port2.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        port1.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
        port2.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
        port1.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        port1.PortionFormat.FillFormat.SolidFillColor.Color = Color.Red;
        port2.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        port2.PortionFormat.FillFormat.SolidFillColor.Color = Color.Blue;

        // Save the presentation
        pres.Save("CustomFontPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}