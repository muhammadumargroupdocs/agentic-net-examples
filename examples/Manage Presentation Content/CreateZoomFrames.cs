using System;
using System.IO;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add two empty slides based on the layout of the first slide
        Aspose.Slides.ISlide slide2 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        Aspose.Slides.ISlide slide3 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);

        // Set background for slide2
        slide2.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide2.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide2.Background.FillFormat.SolidFillColor.Color = Color.Cyan;

        // Set background for slide3
        slide3.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide3.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide3.Background.FillFormat.SolidFillColor.Color = Color.DarkKhaki;

        // Add first zoom frame without custom image
        Aspose.Slides.IZoomFrame zoomFrame1 = presentation.Slides[0].Shapes.AddZoomFrame(50, 50, 200, 200, slide2);
        zoomFrame1.ShowBackground = true;

        // Load custom image
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "logo.png");
        Aspose.Slides.IPPImage image = presentation.Images.AddImage(Aspose.Slides.Images.FromFile(imagePath));

        // Add second zoom frame with custom image
        Aspose.Slides.IZoomFrame zoomFrame2 = presentation.Slides[0].Shapes.AddZoomFrame(300, 50, 200, 200, slide3, image);
        zoomFrame2.LineFormat.Width = 2.0f;
        zoomFrame2.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        zoomFrame2.LineFormat.FillFormat.SolidFillColor.Color = Color.HotPink;
        zoomFrame2.LineFormat.DashStyle = Aspose.Slides.LineDashStyle.DashDot;

        // Save the presentation
        presentation.Save("ZoomFrames.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}