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
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Define output file path
        string resultPath = Path.Combine(Directory.GetCurrentDirectory(), "SectionZoomDemo.pptx");

        // Add a new slide for the section
        Aspose.Slides.ISlide slide = pres.Slides.AddEmptySlide(pres.Slides[0].LayoutSlide);
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = Color.YellowGreen;
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;

        // Add a section containing the new slide
        Aspose.Slides.ISection section = pres.Sections.AddSection("My Section", slide);

        // Add a Section Zoom frame on the first slide
        Aspose.Slides.ISectionZoomFrame zoom = pres.Slides[0].Shapes.AddSectionZoomFrame(50, 50, 200, 100, section);
        zoom.ReturnToParent = true;

        // Save the presentation
        pres.Save(resultPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}