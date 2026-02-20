using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Manage normal view properties
        pres.ViewProperties.NormalViewProperties.HorizontalBarState = Aspose.Slides.SplitterBarStateType.Restored;
        pres.ViewProperties.NormalViewProperties.VerticalBarState = Aspose.Slides.SplitterBarStateType.Maximized;
        pres.ViewProperties.NormalViewProperties.RestoredTop.AutoAdjust = true; // example value
        pres.ViewProperties.NormalViewProperties.RestoredTop.DimensionSize = 200f; // example value
        pres.ViewProperties.NormalViewProperties.ShowOutlineIcons = false; // example value

        // Save the presentation in PPTX format
        pres.Save("NormalViewRestored.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}