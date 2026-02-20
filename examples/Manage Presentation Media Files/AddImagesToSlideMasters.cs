using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define file paths
        string inputImagePath = "image.png";
        string outputPath = "output.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Load image data
        byte[] imageData = System.IO.File.ReadAllBytes(inputImagePath);

        // Add image to presentation's image collection
        Aspose.Slides.IPPImage img = pres.Images.AddImage(imageData);

        // Get the first master slide
        Aspose.Slides.IMasterSlide master = pres.Masters[0];

        // Add picture frame to the master slide covering the whole slide
        master.Shapes.AddPictureFrame(Aspose.Slides.ShapeType.Rectangle, 0, 0, pres.SlideSize.Size.Width, pres.SlideSize.Size.Height, img);

        // Save the presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}