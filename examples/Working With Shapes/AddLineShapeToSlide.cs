using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

namespace AddLineShapeExample
{
    class Program
    {
        static void Main()
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a line shape to the slide
            Aspose.Slides.IAutoShape lineShape = slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Line, 50, 150, 300, 0);

            // Customize line formatting
            lineShape.LineFormat.Style = Aspose.Slides.LineStyle.ThickBetweenThin;
            lineShape.LineFormat.Width = 10;
            lineShape.LineFormat.DashStyle = Aspose.Slides.LineDashStyle.DashDot;
            lineShape.LineFormat.BeginArrowheadLength = Aspose.Slides.LineArrowheadLength.Short;
            lineShape.LineFormat.BeginArrowheadStyle = Aspose.Slides.LineArrowheadStyle.Oval;
            lineShape.LineFormat.EndArrowheadLength = Aspose.Slides.LineArrowheadLength.Long;
            lineShape.LineFormat.EndArrowheadStyle = Aspose.Slides.LineArrowheadStyle.Triangle;
            lineShape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            lineShape.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Maroon;

            // Cast to GeometryShape to modify geometry
            Aspose.Slides.GeometryShape geometryShape = (Aspose.Slides.GeometryShape)lineShape;

            // Get the first geometry path
            Aspose.Slides.IGeometryPath geometryPath = geometryShape.GetGeometryPaths()[0];

            // Add custom segments to the geometry path
            geometryPath.LineTo(100, 0);
            geometryPath.LineTo(200, 0);

            // Apply the modified geometry back to the shape
            geometryShape.SetGeometryPath(geometryPath);

            // Save the presentation
            presentation.Save("LineShapeExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}