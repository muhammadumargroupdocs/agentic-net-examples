using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        string inputFilePath = Path.Combine(Directory.GetCurrentDirectory(), "input.pptx");
        // Output text file path
        string outputFilePath = Path.Combine(Directory.GetCurrentDirectory(), "AllCapsText.txt");
        // Load the presentation (required by lifecycle rules)
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFilePath);
        // Extract raw text from the presentation
        Aspose.Slides.IPresentationText presentationText = Aspose.Slides.PresentationFactory.Instance.GetPresentationText(inputFilePath, Aspose.Slides.TextExtractionArrangingMode.Unarranged);
        // Write extracted All-Caps text to a file
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            for (int i = 0; i < presentationText.SlidesText.Length; i++)
            {
                Aspose.Slides.ISlideText slideText = presentationText.SlidesText[i];
                string text = slideText.Text;
                if (!string.IsNullOrEmpty(text) && text == text.ToUpper())
                {
                    writer.WriteLine(text);
                }
            }
        }
        // Save the (unchanged) presentation before exiting (required by authoring rules)
        string savedPresentationPath = Path.Combine(Directory.GetCurrentDirectory(), "SavedPresentation.pptx");
        presentation.Save(savedPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        // Dispose the presentation
        presentation.Dispose();
    }
}