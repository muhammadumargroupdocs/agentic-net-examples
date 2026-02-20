using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape with text
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
        shape.FillFormat.FillType = Aspose.Slides.FillType.NoFill;
        Aspose.Slides.ITextFrame tf = shape.TextFrame;
        tf.Text = "Hello World";
        Aspose.Slides.IPortion portion = tf.Paragraphs[0].Portions[0];
        portion.PortionFormat.LatinFont = new Aspose.Slides.FontData("Arial");
        portion.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontUnderline = Aspose.Slides.TextUnderlineType.Single;
        portion.PortionFormat.FontHeight = 24;
        portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion.PortionFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;

        // Highlight the word "Hello" with yellow background
        Aspose.Slides.AutoShape autoShape = (Aspose.Slides.AutoShape)shape;
        autoShape.TextFrame.HighlightText("Hello", System.Drawing.Color.Yellow);

        // Save the presentation
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}