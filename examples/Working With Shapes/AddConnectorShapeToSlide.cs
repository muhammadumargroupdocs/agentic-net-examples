using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Get the shape collection of the first slide
            Aspose.Slides.IShapeCollection shapes = pres.Slides[0].Shapes;

            // Add an ellipse shape
            Aspose.Slides.IAutoShape ellipse = shapes.AddAutoShape(Aspose.Slides.ShapeType.Ellipse, 0, 100, 100, 100);

            // Add a rectangle shape
            Aspose.Slides.IAutoShape rectangle = shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 300, 100, 100);

            // Add a bent connector shape
            Aspose.Slides.IConnector connector = shapes.AddConnector(Aspose.Slides.ShapeType.BentConnector2, 0, 0, 10, 10);

            // Connect the start of the connector to the ellipse
            connector.StartShapeConnectedTo = ellipse;

            // Connect the end of the connector to the rectangle
            connector.EndShapeConnectedTo = rectangle;

            // Reroute the connector to take the shortest possible path
            connector.Reroute();

            // Save the presentation
            string outPath = "ConnectorExample.pptx";
            pres.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}