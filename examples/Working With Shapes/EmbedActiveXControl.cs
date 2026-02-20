using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define output file path
        string outputPath = System.IO.Path.GetFullPath("ActiveXControl.pptm");

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add an ActiveX control (Windows Media Player) to the slide
        Aspose.Slides.IControl control = slide.Controls.AddControl(
            Aspose.Slides.ControlType.WindowsMediaPlayer,
            100f,   // X position
            100f,   // Y position
            200f,   // Width
            50f);   // Height

        // Set control name
        control.Name = "MyControl";

        // Add a property to the control if the collection is available
        if (control.Properties != null)
        {
            control.Properties.Add("AutoPlay", "true");
        }

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptm);
    }
}