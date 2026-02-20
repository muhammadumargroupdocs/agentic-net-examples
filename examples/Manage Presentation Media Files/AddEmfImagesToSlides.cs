using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the EMF image file to be added
        string inputFilePath = "input.emf";
        // Path where the resulting PPTX will be saved
        string outputFilePath = "output.pptx";

        // Read the EMF image into a byte array
        byte[] imageData = System.IO.File.ReadAllBytes(inputFilePath);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add the EMF image to the presentation's image collection
        Aspose.Slides.IPPImage img = pres.Images.AddImage(imageData);

        // Obtain the first slide, or add a blank slide if none exist
        Aspose.Slides.ISlide slide;
        if (pres.Slides.Count > 0)
            slide = pres.Slides[0];
        else
            slide = pres.Slides.AddEmptySlide(pres.LayoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank));

        // Insert the image as a picture frame covering the entire slide
        slide.Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle,
            0,
            0,
            pres.SlideSize.Size.Width,
            pres.SlideSize.Size.Height,
            img);

        // Save the presentation in PPTX format
        pres.Save(outputFilePath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}