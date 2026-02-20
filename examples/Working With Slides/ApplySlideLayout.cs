using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the collection of layout slides from the first master slide
        Aspose.Slides.IMasterLayoutSlideCollection layoutSlides = presentation.Masters[0].LayoutSlides;

        // Try to obtain a TitleAndObject layout, otherwise fall back to Title
        Aspose.Slides.ILayoutSlide layoutSlide = layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.TitleAndObject) ?? layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Title);

        // If still not found, search by known names
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

        // If no suitable layout found, use a Blank layout or add a new one
        if (layoutSlide == null)
        {
            layoutSlide = layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank);
        }
        if (layoutSlide == null)
        {
            layoutSlide = layoutSlides.Add(Aspose.Slides.SlideLayoutType.TitleAndObject, "Title and Content");
        }

        // Insert a new empty slide at the beginning using the selected layout
        presentation.Slides.InsertEmptySlide(0, layoutSlide);

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}