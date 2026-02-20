using System;
using Aspose.Slides;
using System.IO;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Define output file name and path
        System.String resultPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "SectionZoomDemo.pptx");

        // Add a new empty slide with a solid background
        Aspose.Slides.ISlide slide = pres.Slides.AddEmptySlide(pres.Slides[0].LayoutSlide);
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.YellowGreen;
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;

        // Create a section that starts with the new slide
        Aspose.Slides.ISection section = pres.Sections.AddSection("Section 1", slide);

        // Add a Section Zoom frame on the first slide linking to the created section
        Aspose.Slides.ISectionZoomFrame zoom = pres.Slides[0].Shapes.AddSectionZoomFrame(50, 50, 100, 100, section);

        // Save the presentation in PPTX format
        pres.Save(resultPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}