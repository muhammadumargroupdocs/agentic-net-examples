using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Set normal view properties
        pres.ViewProperties.NormalViewProperties.HorizontalBarState = Aspose.Slides.SplitterBarStateType.Restored;
        pres.ViewProperties.NormalViewProperties.VerticalBarState = Aspose.Slides.SplitterBarStateType.Maximized;
        pres.ViewProperties.NormalViewProperties.RestoredTop.AutoAdjust = true;
        pres.ViewProperties.NormalViewProperties.RestoredTop.DimensionSize = 200f;
        pres.ViewProperties.NormalViewProperties.ShowOutlineIcons = false;

        // Save the presentation
        pres.Save("NormalViewPropertiesDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}