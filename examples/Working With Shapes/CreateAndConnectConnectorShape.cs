using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the shape collection of the first slide
        Aspose.Slides.IShapeCollection shapes = presentation.Slides[0].Shapes;

        // Add an ellipse shape
        Aspose.Slides.IAutoShape ellipse = shapes.AddAutoShape(Aspose.Slides.ShapeType.Ellipse, 0, 100, 100, 100);

        // Add a rectangle shape
        Aspose.Slides.IAutoShape rectangle = shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 300, 100, 100);

        // Add a bent connector shape
        Aspose.Slides.IConnector connector = shapes.AddConnector(Aspose.Slides.ShapeType.BentConnector2, 0, 0, 10, 10);

        // Connect the connector to the ellipse and rectangle
        connector.StartShapeConnectedTo = ellipse;
        connector.EndShapeConnectedTo = rectangle;

        // Reroute the connector to take the shortest path
        connector.Reroute();

        // Save the presentation
        string outputPath = "ConnectShapes.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}