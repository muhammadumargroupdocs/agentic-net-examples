using System;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.html";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create HTML export options
            Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

            // Set the HtmlFormatter (using a simple document formatter)
            htmlOptions.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter("", false);

            // Save the presentation as HTML5 using the specified options
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html5, htmlOptions);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}