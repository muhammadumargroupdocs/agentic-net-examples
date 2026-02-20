using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SummaryZoomExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // First slide – set background to Red
            Aspose.Slides.ISlide slide = presentation.Slides[0];
            slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
            slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Red;
            // Add first section
            string section1 = "Section 1";
            presentation.Sections.AddSection(section1, slide);

            // Add second slide – set background to Green
            slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
            slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
            slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Green;
            string section2 = "Section 2";
            presentation.Sections.AddSection(section2, slide);

            // Add third slide – set background to Blue
            slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
            slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
            slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;
            string section3 = "Section 3";
            presentation.Sections.AddSection(section3, slide);

            // Add fourth slide – set background to Yellow
            slide = presentation.Slides.AddEmptySlide(presentation.Slides[0].LayoutSlide);
            slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
            slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Yellow;
            string section4 = "Section 4";
            presentation.Sections.AddSection(section4, slide);

            // Add Summary Zoom frame on the first slide
            Aspose.Slides.ISummaryZoomFrame summaryZoom = presentation.Slides[0].Shapes.AddSummaryZoomFrame(50, 50, 200, 200);

            // Save the presentation in PPTX format
            string outputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SummaryZoom.pptx");
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}