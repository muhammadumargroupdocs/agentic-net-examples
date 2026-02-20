using System;
using Aspose.Slides;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape that will be converted to a custom geometry shape
        Aspose.Slides.GeometryShape shape = (Aspose.Slides.GeometryShape)presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 200);

        // Retrieve the first geometry path of the shape
        Aspose.Slides.IGeometryPath geometryPath = shape.GetGeometryPaths()[0];

        // Define custom geometry (a simple triangle)
        geometryPath.MoveTo(0, 0);
        geometryPath.LineTo(shape.Width, 0);
        geometryPath.LineTo(shape.Width / 2, shape.Height);
        geometryPath.CloseFigure();

        // Apply the custom geometry to the shape
        shape.SetGeometryPath(geometryPath);

        // Apply solid fill (blue) to the shape
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = Color.Blue;

        // Apply solid stroke (red) with a width of 2 points
        shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.LineFormat.FillFormat.SolidFillColor.Color = Color.Red;
        shape.LineFormat.Width = 2.0;

        // Save the presentation
        presentation.Save("CustomShape.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}