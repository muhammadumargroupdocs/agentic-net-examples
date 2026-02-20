using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Get full path to data directory
        string dataDir = System.IO.Path.GetFullPath("Data");
        // Load presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(System.IO.Path.Combine(dataDir, "input.pptm"));
        // Get first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];
        // Access first control
        Aspose.Slides.IControl control = slide.Controls[0];
        if (control.Name == "MyControl" && control.Properties != null)
        {
            string propName = "Caption";
            control.Properties[propName] = "New Caption";
        }
        // Access second control if it exists
        if (slide.Controls.Count > 1)
        {
            control = slide.Controls[1];
            if (control.Name == "AnotherControl" && control.Properties != null)
            {
                string propName2 = "Value";
                control.Properties[propName2] = "123";
            }
        }
        // Iterate all controls and modify their frames
        foreach (Aspose.Slides.IControl ctrl in slide.Controls)
        {
            Aspose.Slides.IShapeFrame frame = ctrl.Frame;
            ctrl.Frame = new Aspose.Slides.ShapeFrame(frame.X, frame.Y + 10, frame.Width, frame.Height, frame.FlipH, frame.FlipV, frame.Rotation);
        }
        // Save presentation after modifications
        pres.Save(System.IO.Path.Combine(dataDir, "output.pptm"), Aspose.Slides.Export.SaveFormat.Pptm);
        // Clear controls and save again
        slide.Controls.Clear();
        pres.Save(System.IO.Path.Combine(dataDir, "output_final.pptm"), Aspose.Slides.Export.SaveFormat.Pptm);
    }
}