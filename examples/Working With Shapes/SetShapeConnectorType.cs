using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the shape collection of the first slide
        Aspose.Slides.IShapeCollection shapes = presentation.Slides[0].Shapes;

        // Add an ellipse shape
        Aspose.Slides.IAutoShape ellipse = (Aspose.Slides.IAutoShape)shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Ellipse, 0, 100, 100, 100);

        // Add a rectangle shape
        Aspose.Slides.IAutoShape rectangle = (Aspose.Slides.IAutoShape)shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 200, 300, 100, 100);

        // Add a connector (initially a bent connector)
        Aspose.Slides.IConnector connector = (Aspose.Slides.IConnector)shapes.AddConnector(
            Aspose.Slides.ShapeType.BentConnector2, 0, 0, 10, 10);

        // Connect the shapes
        connector.StartShapeConnectedTo = ellipse;
        connector.EndShapeConnectedTo = rectangle;

        // Set the connector type to Straight (alternatives: BentConnector2 for elbow, CurvedConnector2 for curve)
        connector.ShapeType = Aspose.Slides.ShapeType.StraightConnector1;

        // Reroute the connector to take the shortest path
        connector.Reroute();

        // Save the presentation
        presentation.Save("ConnectorExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}