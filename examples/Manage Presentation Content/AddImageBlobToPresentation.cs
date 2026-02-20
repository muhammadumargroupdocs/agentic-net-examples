using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesBlobExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the image file path and output presentation path
            System.String imagePath = "image.jpg";
            System.String outputPath = "output.ppt";

            // Open a file stream for the image (BLOB)
            System.IO.FileStream imageStream = new System.IO.FileStream(imagePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add the image to the presentation's image collection from the stream
            Aspose.Slides.IPPImage ppImage = presentation.Images.AddImage(imageStream, Aspose.Slides.LoadingStreamBehavior.KeepLocked);

            // Insert the image as a picture frame on the first slide
            presentation.Slides[0].Shapes.AddPictureFrame(
                Aspose.Slides.ShapeType.Rectangle,
                0,
                0,
                ppImage.Width,
                ppImage.Height,
                ppImage);

            // Save the presentation in PPT format
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

            // Clean up resources
            presentation.Dispose();
            imageStream.Close();
        }
    }
}