using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Input image file path and output PPTX file path
        string inputFilePath = "image.png";
        string outputFilePath = "output.pptx";

        // Read image data into a byte array
        byte[] imageData = File.ReadAllBytes(inputFilePath);

        // Create a new presentation (contains one empty slide by default)
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add the image to the presentation's image collection
        Aspose.Slides.IPPImage img = pres.Images.AddImage(imageData);

        // Get the first slide; if none exists, add a blank slide
        Aspose.Slides.ISlide slide;
        if (pres.Slides.Count > 0)
        {
            slide = pres.Slides[0];
        }
        else
        {
            slide = pres.Slides.AddEmptySlide(pres.LayoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank));
        }

        // Add a picture frame that covers the entire slide area
        slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            0,
            0,
            pres.SlideSize.Size.Width,
            pres.SlideSize.Size.Height,
            img);

        // Save the presentation as PPTX
        pres.Save(outputFilePath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}