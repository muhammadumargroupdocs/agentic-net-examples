using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define output directory
        string outputDir = Path.Combine(Environment.CurrentDirectory, "Output");
        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the layout slide collection of the first master
        Aspose.Slides.IMasterLayoutSlideCollection layoutSlides = pres.Masters[0].LayoutSlides;

        // Try to obtain a TitleAndObject layout, fallback to Title, then Blank
        Aspose.Slides.ILayoutSlide layoutSlide = layoutSlides.GetByType(SlideLayoutType.TitleAndObject) ?? layoutSlides.GetByType(SlideLayoutType.Title);
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
            layoutSlide = layoutSlides.GetByType(SlideLayoutType.Blank);
        }
        if (layoutSlide == null)
        {
            layoutSlide = layoutSlides.Add(SlideLayoutType.TitleAndObject, "TitleAndObject");
        }

        // Insert a new empty slide using the selected layout at position 0
        pres.Slides.InsertEmptySlide(0, layoutSlide);

        // Save the presentation
        string outPath = Path.Combine(outputDir, "LayoutDemo.pptx");
        pres.Save(outPath, SaveFormat.Pptx);
        pres.Dispose();
    }
}