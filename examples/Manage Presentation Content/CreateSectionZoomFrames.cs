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

        // Define output file name and path
        string resultFileName = "SectionZoomWithImage.pptx";
        string resultPath = Path.Combine(Directory.GetCurrentDirectory(), resultFileName);

        // Add a slide for the section and set its background
        Aspose.Slides.ISlide slide = pres.Slides.AddEmptySlide(pres.Slides[0].LayoutSlide);
        slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        slide.Background.FillFormat.SolidFillColor.Color = Color.YellowGreen;
        slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;

        // Add a section linked to the slide
        Aspose.Slides.ISection section = pres.Sections.AddSection("My Section", slide);

        // Add a Section Zoom Frame on the first slide
        Aspose.Slides.ISectionZoomFrame sectionZoom = pres.Slides[0].Shapes.AddSectionZoomFrame(50, 50, 200, 100, section);

        // Load a custom image and add it to the presentation
        string imageFileName = "customImage.png";
        string imagePath = Path.Combine(Directory.GetCurrentDirectory(), imageFileName);
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile(imagePath);
        Aspose.Slides.IPPImage ipImage = pres.Images.AddImage(image);

        // Assign the custom image to the Section Zoom Frame
        sectionZoom.ZoomImage = ipImage;

        // Save the presentation
        pres.Save(resultPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}