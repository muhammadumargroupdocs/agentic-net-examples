using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SetShape3DRotation
{
    class Program
    {
        static void Main()
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Index of the slide to work with (first slide)
            int slideIndex = 0;

            // Add a rectangle shape
            Aspose.Slides.IShape rectShape = presentation.Slides[slideIndex].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 50, 50, 200, 100);
            // Set 3D depth
            rectShape.ThreeDFormat.Depth = 3;
            // Set camera rotation (X, Y, Z)
            rectShape.ThreeDFormat.Camera.SetRotation(30, 40, 0);
            // Set camera preset type
            rectShape.ThreeDFormat.Camera.CameraType = Aspose.Slides.CameraPresetType.PerspectiveAbove;
            // Set light rig preset type (using a valid enum value)
            rectShape.ThreeDFormat.LightRig.LightType = Aspose.Slides.LightRigPresetType.Balanced;

            // Add a line shape
            Aspose.Slides.IShape lineShape = presentation.Slides[slideIndex].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Line, 300, 50, 400, 100);
            // Set 3D depth
            lineShape.ThreeDFormat.Depth = 3;
            // Set camera rotation (X, Y, Z)
            lineShape.ThreeDFormat.Camera.SetRotation(30, 40, 0);
            // Set camera preset type
            lineShape.ThreeDFormat.Camera.CameraType = Aspose.Slides.CameraPresetType.PerspectiveAbove;
            // Set light rig preset type
            lineShape.ThreeDFormat.LightRig.LightType = Aspose.Slides.LightRigPresetType.Balanced;

            // Define output path
            string outPath = "SetShape3DRotation.pptx";
            string outDir = Path.GetDirectoryName(Path.GetFullPath(outPath));
            if (!Directory.Exists(outDir))
            {
                Directory.CreateDirectory(outDir);
            }

            // Save the presentation
            presentation.Save(outPath, SaveFormat.Pptx);
        }
    }
}