using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Access the first shape (assumed to be an AutoShape with a text frame)
        Aspose.Slides.IAutoShape autoShape = (Aspose.Slides.IAutoShape)slide.Shapes[0];

        // Get the text frame from the shape
        Aspose.Slides.ITextFrame textFrame = autoShape.TextFrame;

        // Get the first paragraph in the text frame
        Aspose.Slides.IParagraph paragraph = textFrame.Paragraphs[0];

        // Set line spacing properties
        paragraph.ParagraphFormat.SpaceWithin = 80;
        paragraph.ParagraphFormat.SpaceBefore = 40;
        paragraph.ParagraphFormat.SpaceAfter = 40;

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}