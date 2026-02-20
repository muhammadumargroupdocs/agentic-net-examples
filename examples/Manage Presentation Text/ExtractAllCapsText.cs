using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationTextExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputFileName = "input.pptx";
            string inputFilePath = Path.Combine(Directory.GetCurrentDirectory(), inputFileName);

            // Load presentation for saving later
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFilePath);

            // Extract raw text from the presentation (unarranged)
            Aspose.Slides.IPresentationText presentationText = Aspose.Slides.PresentationFactory.Instance.GetPresentationText(
                inputFilePath,
                Aspose.Slides.TextExtractionArrangingMode.Unarranged);

            // Iterate through each slide's text and output all‑caps strings
            for (int i = 0; i < presentationText.SlidesText.Length; i++)
            {
                Aspose.Slides.ISlideText slideText = presentationText.SlidesText[i];
                string text = slideText.Text;

                if (!string.IsNullOrEmpty(text) && text == text.ToUpper())
                {
                    Console.WriteLine("Slide {0} All‑Caps Text: {1}", i + 1, text);
                }
            }

            // Save the presentation before exiting (overwrites original)
            presentation.Save(inputFilePath, Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}