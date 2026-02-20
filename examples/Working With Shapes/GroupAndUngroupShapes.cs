using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace GroupAndUngroupShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Presentation presentation = new Presentation();

            // Define output file path
            string outPath = "GroupAndUngroupShapes_out.pptx";

            // Get the first slide
            ISlide slide = presentation.Slides[0];

            // Add a new empty group shape to the slide
            IGroupShape groupShape = slide.Shapes.AddGroupShape();

            // Add multiple auto shapes to the group
            groupShape.Shapes.AddAutoShape(ShapeType.Rectangle, 50f, 50f, 100f, 100f);
            groupShape.Shapes.AddAutoShape(ShapeType.Rectangle, 200f, 50f, 100f, 100f);
            groupShape.Shapes.AddAutoShape(ShapeType.Rectangle, 50f, 200f, 100f, 100f);
            groupShape.Shapes.AddAutoShape(ShapeType.Rectangle, 200f, 200f, 100f, 100f);

            // ----- Ungroup the shapes -----
            // Clone each shape from the group back to the slide
            int shapeCount = groupShape.Shapes.Count;
            for (int i = 0; i < shapeCount; i++)
            {
                IShape innerShape = groupShape.Shapes[i];
                slide.Shapes.AddClone(innerShape);
            }

            // Remove the now empty group shape from the slide
            slide.Shapes.Remove(groupShape);
            // ------------------------------

            // Save the presentation
            presentation.Save(outPath, SaveFormat.Pptx);
        }
    }
}