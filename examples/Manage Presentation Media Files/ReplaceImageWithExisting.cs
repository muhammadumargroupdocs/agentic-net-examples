using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define directories and file paths
        string dataDir = Path.Combine(Environment.CurrentDirectory, "Data");
        string inputPath = Path.Combine(dataDir, "input.pptx");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Find the first picture shape on the slide
        Aspose.Slides.PictureFrame pictureFrame = null;
        foreach (Aspose.Slides.IShape shape in slide.Shapes)
        {
            if (shape is Aspose.Slides.PictureFrame)
            {
                pictureFrame = (Aspose.Slides.PictureFrame)shape;
                break;
            }
        }

        // Replace the picture's image with another image already in the collection
        if (pictureFrame != null && pres.Images.Count > 1)
        {
            Aspose.Slides.IPPImage existingImage = pres.Images[1];
            pictureFrame.PictureFormat.Picture.Image = existingImage;
        }

        // Save the modified presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}