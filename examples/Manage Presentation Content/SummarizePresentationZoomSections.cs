using System;
using System.IO;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Presentation presentation = new Presentation();

        // First slide – set background and add first section
        ISlide slide = presentation.Slides[0];
        slide.Background.Type = BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = Color.Red;
        presentation.Sections.AddSection("Section 1", slide);

        // Second slide – set background and add second section
        slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        slide.Background.Type = BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = Color.Green;
        presentation.Sections.AddSection("Section 2", slide);

        // Third slide – set background and add third section
        slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        slide.Background.Type = BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = Color.Blue;
        presentation.Sections.AddSection("Section 3", slide);

        // Fourth slide – set background and add fourth section
        slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        slide.Background.Type = BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = Color.Yellow;
        presentation.Sections.AddSection("Section 4", slide);

        // Add a Summary Zoom frame to the first slide
        ISummaryZoomFrame summaryZoom = presentation.Slides[0].Shapes.AddSummaryZoomFrame(50, 50, 200, 150);

        // Save the presentation
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "SummaryZoom.pptx");
        presentation.Save(outputPath, SaveFormat.Pptx);
    }
}