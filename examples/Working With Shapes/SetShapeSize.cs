using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the output directory and file name
            string outputDir = Path.GetFullPath("Output");
            // Ensure the directory exists
            Directory.CreateDirectory(outputDir);
            string outputPath = Path.Combine(outputDir, "ActiveXControlSize.pptm");

            // Create a new presentation
            Presentation pres = new Presentation();

            // Get the first slide (a new presentation contains one empty slide)
            ISlide slide = pres.Slides[0];

            // Add an ActiveX control (Windows Media Player) to the slide
            // Parameters: ControlType, X, Y, Width, Height
            slide.Controls.AddControl(ControlType.WindowsMediaPlayer, 100f, 100f, 200f, 100f);

            // Retrieve the added control (first control in the collection)
            IControl control = slide.Controls[0];

            // Get the current frame of the control
            IShapeFrame currentFrame = control.Frame;

            // Set new width and height by creating a new ShapeFrame
            // Keep other frame properties unchanged
            control.Frame = new ShapeFrame(
                currentFrame.X,          // X position
                currentFrame.Y,          // Y position
                300f,                    // New width
                150f,                    // New height
                currentFrame.FlipH,      // Flip horizontally flag
                currentFrame.FlipV,      // Flip vertically flag
                currentFrame.Rotation    // Rotation angle
            );

            // Save the presentation in PPTM format
            pres.Save(outputPath, SaveFormat.Pptm);
        }
    }
}