using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define directories and file paths
            string dataDir = "Data";
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);

            string inputPptxPath = Path.Combine(dataDir, "input.pptx");
            string outputPptxPath = Path.Combine(dataDir, "output.pptx");
            string oldImagePath = Path.Combine(dataDir, "old.png");
            string newImagePath = Path.Combine(dataDir, "new.png");

            // Load existing presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPptxPath);

            // Add the old image to the presentation's image collection
            byte[] oldImageData = File.ReadAllBytes(oldImagePath);
            Aspose.Slides.IPPImage oldImage = presentation.Images.AddImage(oldImageData);

            // Replace the image data with a new image
            byte[] newImageData = File.ReadAllBytes(newImagePath);
            oldImage.ReplaceImage(newImageData);

            // Save the modified presentation
            presentation.Save(outputPptxPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}