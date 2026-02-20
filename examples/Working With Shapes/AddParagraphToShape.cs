using System;
using Aspose.Slides;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a rectangle auto shape to the first slide
            Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle,
                100f,   // X position
                100f,   // Y position
                400f,   // Width
                100f,   // Height
                false   // isGrouped
            );

            // Add an empty text frame to the shape
            shape.AddTextFrame("");

            // Clear any default paragraphs
            shape.TextFrame.Paragraphs[0].Portions.Clear();

            // Create two portions with text
            Aspose.Slides.IPortion portion0 = new Aspose.Slides.Portion("Hello");
            Aspose.Slides.IPortion portion1 = new Aspose.Slides.Portion("World");

            // Add portions to the first paragraph
            shape.TextFrame.Paragraphs[0].Portions.Add(portion0);
            shape.TextFrame.Paragraphs[0].Portions.Add(portion1);

            // Set local font height values at different levels
            presentation.DefaultTextStyle.GetLevel(0).DefaultPortionFormat.FontHeight = 20f;               // Presentation level
            shape.TextFrame.Paragraphs[0].ParagraphFormat.DefaultPortionFormat.FontHeight = 18f;        // Paragraph level
            shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 16f;                    // Portion 0
            shape.TextFrame.Paragraphs[0].Portions[1].PortionFormat.FontHeight = 14f;                    // Portion 1

            // Save the presentation
            string fileName = "output.pptx";
            presentation.Save(fileName, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}