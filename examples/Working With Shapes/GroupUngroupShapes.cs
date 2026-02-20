using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add two auto shapes to the slide
        Aspose.Slides.IAutoShape shape1 = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 100, 100);
        shape1.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape1.FillFormat.SolidFillColor.Color = Color.Red;

        Aspose.Slides.IAutoShape shape2 = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Ellipse, 200, 50, 100, 100);
        shape2.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape2.FillFormat.SolidFillColor.Color = Color.Blue;

        // Group the two shapes
        Aspose.Slides.IGroupShape group = slide.Shapes.AddGroupShape();

        // Add clones of the shapes into the group
        group.Shapes.AddClone(shape1);
        group.Shapes.AddClone(shape2);

        // Remove original shapes from the slide
        slide.Shapes.Remove(shape1);
        slide.Shapes.Remove(shape2);

        // Ungroup: copy shapes from the group back to the slide
        Aspose.Slides.IShape[] groupedShapes = group.Shapes.ToArray();
        foreach (Aspose.Slides.IShape s in groupedShapes)
        {
            slide.Shapes.AddClone(s);
        }

        // Remove the empty group shape
        slide.Shapes.Remove(group);

        // Save the presentation
        presentation.Save("GroupUngroupDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}