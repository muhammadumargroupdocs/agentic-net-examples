using System;
using System.Text;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Util;

class Program
{
    static void Main(string[] args)
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Output HTML file path
        string outputPath = "output.html";

        // Load the presentation
        Presentation presentation = new Presentation(inputPath);

        // Options for HTML conversion
        TextToHtmlConversionOptions htmlOptions = new TextToHtmlConversionOptions();

        // StringBuilder to accumulate HTML content
        StringBuilder htmlBuilder = new StringBuilder();

        // Iterate through all slides
        for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
        {
            // Get all text frames on the current slide
            ITextFrame[] textFrames = SlideUtil.GetAllTextFrames(presentation, true);
            foreach (ITextFrame textFrame in textFrames)
            {
                // Export paragraphs of the text frame to HTML
                string htmlFragment = textFrame.Paragraphs.ExportToHtml(0, textFrame.Paragraphs.Count, htmlOptions);
                htmlBuilder.AppendLine(htmlFragment);
            }
        }

        // Write the accumulated HTML to a file
        File.WriteAllText(outputPath, htmlBuilder.ToString());

        // Save the presentation (as required by authoring rules)
        presentation.Save(inputPath, SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}