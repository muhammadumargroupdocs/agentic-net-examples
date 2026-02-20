using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Util;

namespace ManagePresentationText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation for extraction
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Use PresentationFactory to get raw text from the presentation
            Aspose.Slides.PresentationFactory factory = Aspose.Slides.PresentationFactory.Instance;
            Aspose.Slides.IPresentationText ipresentationText = factory.GetPresentationText(inputPath, Aspose.Slides.TextExtractionArrangingMode.Unarranged);
            // Cast to concrete PresentationText to access SlidesText property
            Aspose.Slides.PresentationText presentationText = (Aspose.Slides.PresentationText)ipresentationText;

            // Iterate through each slide's extracted text
            foreach (Aspose.Slides.ISlideText slideText in presentationText.SlidesText)
            {
                // Output the slide text (all-caps effect handling can be added here if needed)
                Console.WriteLine(slideText.Text);
            }

            // Save the presentation before exiting (as required by authoring rules)
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}