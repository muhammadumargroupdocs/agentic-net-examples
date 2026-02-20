using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Define output file path
        System.String resultPath = "CustomShape.pptx";

        // Add a rectangle auto shape to the first slide
        Aspose.Slides.GeometryShape shape = (Aspose.Slides.GeometryShape)pres.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50f, 50f, 200f, 100f);

        // Get the geometry path of the shape
        Aspose.Slides.IGeometryPath geometryPath = shape.GetGeometryPaths()[0];

        // Modify the geometry by adding line segments
        geometryPath.LineTo(200f, 0f, 0);
        geometryPath.LineTo(0f, 100f, 1);

        // Apply the modified geometry to the shape
        shape.SetGeometryPath(geometryPath);

        // Save the presentation
        pres.Save(resultPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}