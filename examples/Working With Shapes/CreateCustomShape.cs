using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape to serve as the base for custom geometry
        Aspose.Slides.GeometryShape shape = (Aspose.Slides.GeometryShape)pres.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 200);

        // Retrieve the first geometry path of the shape
        Aspose.Slides.IGeometryPath geometryPath = shape.GetGeometryPaths()[0];

        // Add custom line segments to the geometry path
        geometryPath.LineTo(300, 100, 0);
        geometryPath.LineTo(300, 300, 0);

        // Apply the modified geometry path back to the shape
        shape.SetGeometryPath(geometryPath);

        // Set a pattern fill for the shape
        shape.FillFormat.FillType = Aspose.Slides.FillType.Pattern;
        shape.FillFormat.PatternFormat.PatternStyle = Aspose.Slides.PatternStyle.DiagonalCross;
        shape.FillFormat.PatternFormat.ForeColor.Color = Color.FromArgb(255, 0, 0); // Red foreground
        shape.FillFormat.PatternFormat.BackColor.Color = Color.FromArgb(255, 255, 255); // White background

        // Configure the shape's stroke (outline)
        shape.LineFormat.Width = 5;
        shape.LineFormat.FillFormat.SolidFillColor.Color = Color.Blue;

        // Save the presentation
        string outPath = "CustomShape.pptx";
        pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}