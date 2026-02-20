using System;
using Aspose.Slides;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape to the first slide
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);

        // Add an empty text frame to the shape
        shape.AddTextFrame(" ");

        // Remove the default portion
        shape.TextFrame.Paragraphs[0].Portions.Clear();

        // Create the first portion with custom text
        Aspose.Slides.IPortion portion1 = new Aspose.Slides.Portion("Hello ");

        // Apply character formatting to the first portion
        portion1.PortionFormat.FontHeight = 24;
        portion1.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        portion1.PortionFormat.FontItalic = Aspose.Slides.NullableBool.False;
        portion1.PortionFormat.FontUnderline = Aspose.Slides.TextUnderlineType.Single;
        portion1.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion1.PortionFormat.FillFormat.SolidFillColor.Color = Color.Blue;

        // Create the second portion with custom text
        Aspose.Slides.IPortion portion2 = new Aspose.Slides.Portion("World!");

        // Apply character formatting to the second portion
        portion2.PortionFormat.FontHeight = 24;
        portion2.PortionFormat.FontBold = Aspose.Slides.NullableBool.False;
        portion2.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
        portion2.PortionFormat.FontUnderline = Aspose.Slides.TextUnderlineType.Double;
        portion2.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion2.PortionFormat.FillFormat.SolidFillColor.Color = Color.Red;

        // Add the portions to the shape's first paragraph
        shape.TextFrame.Paragraphs[0].Portions.Add(portion1);
        shape.TextFrame.Paragraphs[0].Portions.Add(portion2);

        // Save the presentation
        string outPath = "PortionFormatting.pptx";
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up
        presentation.Dispose();
    }
}