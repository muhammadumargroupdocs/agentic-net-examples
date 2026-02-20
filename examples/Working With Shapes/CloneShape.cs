using System;

class Program
{
    static void Main(string[] args)
    {
        // Input and output file paths
        string inputFile = "input.pptx";
        string outputFile = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile);

        // Source slide and its shapes
        Aspose.Slides.ISlide srcSlide = pres.Slides[0];
        Aspose.Slides.IShapeCollection srcShapes = srcSlide.Shapes;

        // Get a blank layout slide from the first master
        Aspose.Slides.ILayoutSlide blankLayout = pres.Masters[0].LayoutSlides.GetByType(Aspose.Slides.SlideLayoutType.Blank);

        // Add a new empty slide based on the blank layout
        Aspose.Slides.ISlide destSlide = pres.Slides.AddEmptySlide(blankLayout);
        Aspose.Slides.IShapeCollection destShapes = destSlide.Shapes;

        // Positions for cloned shapes
        float xPos1 = 100f;
        float yPos1 = 100f;
        float xPos2 = 200f;
        float yPos2 = 200f;
        int insertIndex = 0;

        // Clone shapes with specified positions
        destShapes.AddClone(srcShapes[1], xPos1, yPos1 + srcShapes[0].Height);
        destShapes.AddClone(srcShapes[2]);
        destShapes.InsertClone(insertIndex, srcShapes[0], xPos2, yPos2);

        // Save the modified presentation
        pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}