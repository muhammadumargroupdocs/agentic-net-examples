using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
        // Add an empty text frame to the shape
        shape.AddTextFrame("");
        // Remove shape fill
        shape.FillFormat.FillType = Aspose.Slides.FillType.NoFill;
        // Get the text frame
        Aspose.Slides.ITextFrame txtFrame = shape.TextFrame;
        // Set the anchoring type to Bottom
        txtFrame.TextFrameFormat.AnchoringType = Aspose.Slides.TextAnchorType.Bottom;
        // Access the first paragraph and its first portion
        Aspose.Slides.IParagraph para = txtFrame.Paragraphs[0];
        Aspose.Slides.IPortion portion = para.Portions[0];
        // Set the text content
        portion.Text = "Anchored at Bottom";
        // Set portion fill to solid black
        portion.PortionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        portion.PortionFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
        // Save the presentation as PPTX
        string outputPath = "SetAnchorTextFrame.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        // Clean up
        presentation.Dispose();
    }
}