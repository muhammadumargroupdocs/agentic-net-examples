using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationMediaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output directory
            string outDir = "Output";
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Define image file path (ensure the image exists at this location)
            string imagePath = Path.Combine(Environment.CurrentDirectory, "sample.jpg");

            // Create a new presentation
            Presentation presentation = new Presentation();

            // Open a file stream for the image
            FileStream imageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);

            // Add image to the presentation's image collection
            IPPImage ippImage = presentation.Images.AddImage(imageStream, LoadingStreamBehavior.KeepLocked);

            // Add a picture frame shape to the first slide using the added image
            ISlide slide = presentation.Slides[0];
            slide.Shapes.AddPictureFrame(ShapeType.Rectangle, 50, 50, 400, 300, ippImage);

            // Save the presentation as PPTX
            string outPath = Path.Combine(outDir, "ImagePresentation.pptx");
            presentation.Save(outPath, SaveFormat.Pptx);

            // Clean up resources
            imageStream.Close();
            presentation.Dispose();
        }
    }
}