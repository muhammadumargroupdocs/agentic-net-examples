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

        // Path to the background image file
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "background.jpg");

        // Load the image into the presentation
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage picture = presentation.Images.AddImage(image);

        // Set the background of the first slide to the image
        presentation.Slides[0].Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        presentation.Slides[0].Background.FillFormat.FillType = Aspose.Slides.FillType.Picture;
        presentation.Slides[0].Background.FillFormat.PictureFillFormat.Picture.Image = picture;

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "output.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}