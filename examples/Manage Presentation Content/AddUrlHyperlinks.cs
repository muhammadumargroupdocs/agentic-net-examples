using System;

namespace AsposeSlidesHyperlinkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output file path
            System.String outputPath = "HyperlinkExample.ppt";

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a rectangle auto shape to the first slide
            Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle,
                50f,   // X position
                50f,   // Y position
                400f,  // Width
                100f   // Height
            );

            // Add a text frame with the display text
            shape.AddTextFrame("Click here to visit OpenAI");

            // Assign an external URL hyperlink to the text portion
            shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick =
                new Aspose.Slides.Hyperlink("https://www.openai.com");

            // Save the presentation in PPT format
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}