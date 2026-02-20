using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

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

        // Load the image file to be used as background
        string dataDir = Path.Combine(Directory.GetCurrentDirectory(), "Data");
        string imagePath = Path.Combine(dataDir, "background.jpg");
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage ipImage = presentation.Images.AddImage(image);

        // Configure the background fill to use the picture
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Picture;
        slide.Background.FillFormat.PictureFillFormat.Picture.Image = ipImage;

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "ImageBackground.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}