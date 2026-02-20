using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Set the slide background to use its own background
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;

        // Set the fill type to picture
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Picture;

        // Load an image from file system
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "background.jpg");
        Aspose.Slides.IPPImage image = presentation.Images.AddImage(Aspose.Slides.Images.FromFile(imagePath));

        // Assign the image to the background picture fill
        slide.Background.FillFormat.PictureFillFormat.Picture.Image = image;

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "ImageBackground.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}