using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);

        // Remove fill from the shape
        shape.FillFormat.FillType = Aspose.Slides.FillType.NoFill;

        // Get the text frame of the shape
        Aspose.Slides.ITextFrame tf = shape.TextFrame;

        // Set the text
        tf.Text = "Hello Aspose!";

        // Get the first portion of the first paragraph
        Aspose.Slides.IPortion portion = tf.Paragraphs[0].Portions[0];

        // Assign a custom font to the portion
        portion.PortionFormat.LatinFont = new Aspose.Slides.FontData("CustomFont");

        // Set additional font properties
        portion.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontUnderline = Aspose.Slides.TextUnderlineType.Single;
        portion.PortionFormat.FontHeight = 24f;

        // Set fill color for the text
        portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Blue;

        // Save the presentation
        pres.Save("CustomFontPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}