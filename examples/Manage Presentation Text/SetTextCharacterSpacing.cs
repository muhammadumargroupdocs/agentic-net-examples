using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Access the first slide
            ISlide slide = presentation.Slides[0];

            // Assume the first shape is an AutoShape with a text frame
            IAutoShape autoShape = (IAutoShape)slide.Shapes[0];

            // Get the text frame
            ITextFrame textFrame = autoShape.TextFrame;

            // Get the first paragraph
            IParagraph paragraph = textFrame.Paragraphs[0];

            // Get the first portion of the paragraph
            IPortion portion = paragraph.Portions[0];

            // Set character (intercharacter) spacing
            portion.PortionFormat.Spacing = 2.0f; // Adjust spacing as needed

            // Save the modified presentation
            presentation.Save(outputPath, SaveFormat.Pptx);
        }
    }
}