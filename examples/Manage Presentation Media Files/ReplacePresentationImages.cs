using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Paths for the source presentation, the new image, and the output presentation
        string inputPresentationPath = "input.pptx";
        string newImagePath = "newImage.png";
        string outputPresentationPath = "output.pptx";

        // Load the existing presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPresentationPath);

        // Read the new image data into a byte array
        byte[] newImageData = File.ReadAllBytes(newImagePath);

        // Replace the first image in the presentation's image collection, if any
        if (pres.Images.Count > 0)
        {
            Aspose.Slides.IPPImage existingImage = pres.Images[0];
            existingImage.ReplaceImage(newImageData);
        }

        // Save the modified presentation
        pres.Save(outputPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        pres.Dispose();
    }
}