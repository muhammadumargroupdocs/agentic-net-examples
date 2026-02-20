using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace UngroupShapeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Add a group shape to the slide
            Aspose.Slides.IGroupShape group = slide.Shapes.AddGroupShape();

            // Add some rectangles inside the group shape
            group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50f, 50f, 100f, 100f);
            group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 200f, 50f, 100f, 100f);
            group.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 350f, 50f, 100f, 100f);

            // Ungroup the group shape by cloning its inner shapes to the slide
            for (int i = 0; i < group.Shapes.Count; i++)
            {
                Aspose.Slides.IShape innerShape = group.Shapes[i];
                slide.Shapes.AddClone(innerShape);
            }

            // Remove the original group shape from the slide
            slide.Shapes.Remove(group);

            // Save the presentation
            string outFile = "UngroupShape.pptx";
            pres.Save(outFile, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}