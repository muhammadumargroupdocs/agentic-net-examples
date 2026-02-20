using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a rectangle AutoShape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);

        // Remove fill from the shape
        shape.FillFormat.FillType = Aspose.Slides.FillType.NoFill;

        // Set the text of the shape
        shape.TextFrame.Text = "Hello Aspose.Slides!";

        // Access the first portion of the first paragraph
        Aspose.Slides.IPortion portion = shape.TextFrame.Paragraphs[0].Portions[0];

        // Set font properties
        portion.PortionFormat.LatinFont = new Aspose.Slides.FontData("Arial");
        portion.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontUnderline = Aspose.Slides.TextUnderlineType.Single;
        portion.PortionFormat.FontHeight = 24f;
        portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion.PortionFormat.FillFormat.SolidFillColor.Color = Color.Blue;

        // Save the presentation
        pres.Save("ManagedTextFont.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        pres.Dispose();
    }
}