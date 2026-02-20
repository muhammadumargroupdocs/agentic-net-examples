using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationTextColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape to hold the text frame
            Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle,
                50,   // X position
                50,   // Y position
                400,  // Width
                200   // Height
            );

            // Add a text frame with sample text
            shape.AddTextFrame("Column 1 text\nColumn 2 text\nColumn 3 text");

            // Access the text frame
            Aspose.Slides.ITextFrame textFrame = shape.TextFrame;

            // Set the number of columns and spacing between them
            textFrame.TextFrameFormat.ColumnCount = 3;
            textFrame.TextFrameFormat.ColumnSpacing = 10.0; // points

            // Save the presentation
            string outPath = "output.pptx";
            presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}