using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add two empty slides based on the layout of the first slide
        Aspose.Slides.ISlide slide2 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        Aspose.Slides.ISlide slide3 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);

        // Set background for the first new slide
        slide2.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide2.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide2.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Cyan;

        // Set background for the second new slide
        slide3.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide3.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide3.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.DarkKhaki;

        // Add a zoom frame linking to the first new slide
        Aspose.Slides.IZoomFrame zoomFrame1 = presentation.Slides[0].Shapes.AddZoomFrame(50, 50, 100, 100, slide2);
        zoomFrame1.ShowBackground = true;

        // Prepare an image for the second zoom frame
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "logo.png");
        Aspose.Slides.IPPImage image = presentation.Images.AddImage(Aspose.Slides.Images.FromFile(imagePath));

        // Add a zoom frame linking to the second new slide with an image
        Aspose.Slides.IZoomFrame zoomFrame2 = presentation.Slides[0].Shapes.AddZoomFrame(200, 50, 100, 100, slide3, image);
        zoomFrame2.LineFormat.Width = 5;
        zoomFrame2.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        zoomFrame2.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.HotPink;
        zoomFrame2.LineFormat.DashStyle = Aspose.Slides.LineDashStyle.DashDot;

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "ZoomFramesDemo.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}