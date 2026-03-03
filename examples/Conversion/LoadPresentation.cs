using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load presentation from a file path
        var filePath = "input.pptx";
        using (var presentation = new Aspose.Slides.Presentation(filePath))
        {
            // Save the loaded presentation
            presentation.Save("output_from_file.pptx", SaveFormat.Pptx);
        }

        // Load presentation from a stream
        using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            using (var presentation = new Aspose.Slides.Presentation(fileStream))
            {
                presentation.Save("output_from_stream.pptx", SaveFormat.Pptx);
            }
        }

        // Load presentation from a byte array
        var fileBytes = File.ReadAllBytes(filePath);
        var presentationFromBytes = Aspose.Slides.PresentationFactory.Instance.ReadPresentation(fileBytes);
        presentationFromBytes.Save("output_from_bytes.pptx", SaveFormat.Pptx);
        presentationFromBytes.Dispose();
    }
}