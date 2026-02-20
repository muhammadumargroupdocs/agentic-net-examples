using System;
using System.IO;
using System.Drawing;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Configure the first slide background
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.LightBlue;

        // Add first section with a colored slide
        Aspose.Slides.ISlide sectionSlide1 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        sectionSlide1.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        sectionSlide1.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        sectionSlide1.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.LightCoral;
        Aspose.Slides.ISection section1 = presentation.Sections.AddSection("Section 1", sectionSlide1);

        // Add second section with a colored slide
        Aspose.Slides.ISlide sectionSlide2 = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
        sectionSlide2.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        sectionSlide2.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        sectionSlide2.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.LightGreen;
        Aspose.Slides.ISection section2 = presentation.Sections.AddSection("Section 2", sectionSlide2);

        // Add a Summary Zoom frame on the first slide
        Aspose.Slides.ISummaryZoomFrame summaryZoom = presentation.Slides[0].Shapes.AddSummaryZoomFrame(50, 50, 400, 300);

        // Add sections to the Summary Zoom
        summaryZoom.SummaryZoomCollection.AddSummaryZoomSection(section1);
        summaryZoom.SummaryZoomCollection.AddSummaryZoomSection(section2);

        // Remove the first section from the Summary Zoom
        summaryZoom.SummaryZoomCollection.RemoveSummaryZoomSection(section1);

        // Save the presentation
        string outputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SummaryZoomDemo.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}