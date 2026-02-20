using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths for input template (optional) and output presentation
        string inputPath = Path.Combine(Environment.CurrentDirectory, "template.pptx");
        string outputPath = Path.Combine(Environment.CurrentDirectory, "output.pptx");

        // Load existing presentation if template exists; otherwise create a new one
        Aspose.Slides.Presentation presentation;
        if (File.Exists(inputPath))
        {
            presentation = new Aspose.Slides.Presentation(inputPath);
        }
        else
        {
            presentation = new Aspose.Slides.Presentation();
        }

        // Get layout slides collection from the first master slide
        Aspose.Slides.IMasterLayoutSlideCollection layoutSlides = presentation.Masters[0].LayoutSlides;

        // Try to obtain a TitleAndObject layout, fallback to Title, then Blank
        Aspose.Slides.ILayoutSlide layoutSlide = layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.TitleAndObject) ??
                                                layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Title);
        if (layoutSlide == null)
        {
            foreach (Aspose.Slides.ILayoutSlide ls in layoutSlides)
            {
                if (ls.Name == "Title and Content")
                {
                    layoutSlide = ls;
                    break;
                }
            }
        }
        if (layoutSlide == null)
        {
            foreach (Aspose.Slides.ILayoutSlide ls in layoutSlides)
            {
                if (ls.Name == "Title")
                {
                    layoutSlide = ls;
                    break;
                }
            }
        }
        if (layoutSlide == null)
        {
            layoutSlide = layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank);
        }
        if (layoutSlide == null)
        {
            layoutSlide = layoutSlides.Add(Aspose.Slides.SlideLayoutType.TitleAndObject, "TitleAndObject");
        }

        // Insert a new empty slide at the beginning using the selected layout
        presentation.Slides.InsertEmptySlide(0, layoutSlide);

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}