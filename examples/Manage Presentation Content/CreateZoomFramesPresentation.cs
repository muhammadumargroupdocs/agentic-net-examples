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

        // Add two empty slides that will be the targets of the zoom frames
        Aspose.Slides.ISlide slide2 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        Aspose.Slides.ISlide slide3 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);

        // Set background for the first target slide
        slide2.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide2.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide2.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Cyan;

        // Set background for the second target slide
        slide3.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide3.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide3.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.DarkKhaki;

        // Add a zoom frame on the first slide linking to slide2
        Aspose.Slides.IZoomFrame zoomFrame1 = presentation.Slides[0].Shapes.AddZoomFrame(50, 50, 100, 100, slide2);
        zoomFrame1.ShowBackground = true; // Use background of the target slide

        // Load an image to be used for the second zoom frame
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "logo.png");
        Aspose.Slides.IPPImage image = presentation.Images.AddImage(Aspose.Slides.Images.FromFile(imagePath));

        // Add a second zoom frame linking to slide3 and using the custom image
        Aspose.Slides.IZoomFrame zoomFrame2 = presentation.Slides[0].Shapes.AddZoomFrame(200, 50, 100, 100, slide3, image);
        zoomFrame2.LineFormat.Width = 5;
        zoomFrame2.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        zoomFrame2.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.HotPink;
        zoomFrame2.LineFormat.DashStyle = Aspose.Slides.LineDashStyle.DashDot;

        // Save the presentation in PPTX format
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "ZoomFrames.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}