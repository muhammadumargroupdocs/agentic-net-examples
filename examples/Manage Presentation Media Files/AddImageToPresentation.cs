using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input and output file paths
        string inputFilePath = "image.emz";
        string outputFilePath = "result.pptx";

        // Read image data into a byte array
        byte[] imageData = System.IO.File.ReadAllBytes(inputFilePath);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add the image to the presentation's image collection
        Aspose.Slides.IPPImage img = pres.Images.AddImage(imageData);

        // Get the first slide, or add a blank slide if none exist
        Aspose.Slides.ISlide slide;
        if (pres.Slides.Count > 0)
        {
            slide = pres.Slides[0];
        }
        else
        {
            slide = pres.Slides.AddEmptySlide(pres.LayoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank));
        }

        // Add a picture frame that fills the entire slide using the added image
        slide.Shapes.AddPictureFrame(Aspose.Slides.ShapeType.Rectangle, 0, 0, pres.SlideSize.Size.Width, pres.SlideSize.Size.Height, img);

        // Save the presentation
        pres.Save(outputFilePath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}