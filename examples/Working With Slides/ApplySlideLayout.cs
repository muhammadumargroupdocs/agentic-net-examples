using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the layout slides collection from the first master slide
        Aspose.Slides.IMasterLayoutSlideCollection layoutSlides = presentation.Masters[0].LayoutSlides;

        // Try to obtain a TitleAndObject layout, otherwise fall back to Title
        Aspose.Slides.ILayoutSlide layoutSlide = layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.TitleAndObject) ?? layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Title);

        // If still not found, search by name "TitleAndObject"
        if (layoutSlide == null)
        {
            foreach (Aspose.Slides.ILayoutSlide ls in layoutSlides)
            {
                if (ls.Name == "TitleAndObject")
                {
                    layoutSlide = ls;
                    break;
                }
            }
        }

        // If still not found, search by name "Title"
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

        // If still not found, use a Blank layout
        if (layoutSlide == null)
        {
            layoutSlide = layoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank);
        }

        // If still null, add a new TitleAndObject layout slide
        if (layoutSlide == null)
        {
            layoutSlide = layoutSlides.Add(Aspose.Slides.SlideLayoutType.TitleAndObject, "TitleAndObject");
        }

        // Insert an empty slide at position 0 using the selected layout
        presentation.Slides.InsertEmptySlide(0, layoutSlide);

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}