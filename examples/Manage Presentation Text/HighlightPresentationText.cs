using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace HighlightPresentationText
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

            // Get the first shape on the first slide and cast it to AutoShape
            AutoShape autoShape = (AutoShape)presentation.Slides[0].Shapes[0];

            // Highlight the first occurrence of the text "Aspose" in Yellow
            autoShape.TextFrame.HighlightText("Aspose", Color.Yellow);

            // Highlight the whole word "Slides" in LightGreen with whole word matching
            autoShape.TextFrame.HighlightText(
                "Slides",
                Color.LightGreen,
                new TextSearchOptions() { WholeWordsOnly = true },
                null);

            // Save the modified presentation as PPTX
            presentation.Save(outputPath, SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}