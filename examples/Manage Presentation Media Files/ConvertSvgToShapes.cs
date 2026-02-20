using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths for SVG input and PPTX output
        string svgPath = Path.Combine(Environment.CurrentDirectory, "example.svg");
        string outputPath = Path.Combine(Environment.CurrentDirectory, "output.pptx");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Load SVG image from file
        Aspose.Slides.SvgImage svgImage = new Aspose.Slides.SvgImage(svgPath);

        // Add SVG image to the presentation's image collection
        Aspose.Slides.IPPImage ippImage = presentation.Images.AddImage(svgImage);

        // Add a picture frame containing the SVG image to the first slide
        Aspose.Slides.IShape pictureShape = presentation.Slides[0].Shapes.AddPictureFrame(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 300, ippImage);
        Aspose.Slides.PictureFrame pictureFrame = pictureShape as Aspose.Slides.PictureFrame;

        // Convert the SVG picture frame into a group of individual shapes
        if (pictureFrame != null)
        {
            Aspose.Slides.ISvgImage svgImg = pictureFrame.PictureFormat.Picture.Image.SvgImage;
            if (svgImg != null)
            {
                Aspose.Slides.IGroupShape groupShape = presentation.Slides[0].Shapes.AddGroupShape(
                    svgImg,
                    pictureFrame.Frame.X,
                    pictureFrame.Frame.Y,
                    pictureFrame.Frame.Width,
                    pictureFrame.Frame.Height);
                presentation.Slides[0].Shapes.Remove(pictureFrame);
            }
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}