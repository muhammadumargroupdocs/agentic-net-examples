using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace Render3DShapesToJpeg
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a new presentation
                using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation())
                {
                    // Add a rectangle shape with 3D effects to the first slide
                    Aspose.Slides.IAutoShape shape = pres.Slides[0].Shapes.AddAutoShape(
                        Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 200);
                    shape.TextFrame.Text = "3D Shape";

                    // Configure 3D format
                    shape.ThreeDFormat.Depth = 5.0;
                    shape.ThreeDFormat.ExtrusionHeight = 100.0;
                    shape.ThreeDFormat.Material = Aspose.Slides.MaterialPresetType.Plastic;
                    shape.ThreeDFormat.LightRig.LightType = Aspose.Slides.LightRigPresetType.Balanced;
                    shape.ThreeDFormat.LightRig.Direction = Aspose.Slides.LightingDirection.Top;
                    shape.ThreeDFormat.Camera.CameraType = Aspose.Slides.CameraPresetType.PerspectiveContrastingRightFacing;

                    // Render each slide to a JPEG image
                    for (int index = 0; index < pres.Slides.Count; index++)
                    {
                        Aspose.Slides.ISlide slide = pres.Slides[index];
                        Aspose.Slides.IImage image = slide.GetImage();
                        string outputPath = $"slide_{index}.jpg";
                        image.Save(outputPath, Aspose.Slides.ImageFormat.Jpeg);
                    }

                    // Save the presentation before exiting
                    pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}