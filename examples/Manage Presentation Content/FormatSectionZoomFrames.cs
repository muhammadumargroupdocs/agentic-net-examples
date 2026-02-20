using System;
using System.IO;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Configure first slide and add to section
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Red;
        presentation.Sections.AddSection("Section 1", slide);

        // Add second slide and configure
        slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Green;
        presentation.Sections.AddSection("Section 2", slide);

        // Add third slide and configure
        slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;
        presentation.Sections.AddSection("Section 3", slide);

        // Add fourth slide and configure
        slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Yellow;
        presentation.Sections.AddSection("Section 4", slide);

        // Add Summary Zoom Frame on the first slide
        Aspose.Slides.ISummaryZoomFrame summaryZoom = presentation.Slides[0].Shapes.AddSummaryZoomFrame(50, 50, 200, 200);

        // Save the presentation
        string outputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SummaryZoom.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}