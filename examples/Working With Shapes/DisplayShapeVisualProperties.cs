using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ShapeEffectivePropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source presentation
            string sourcePath = "input.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath);

            // Get the first shape on the first slide
            Aspose.Slides.IShape shape = presentation.Slides[0].Shapes[0];

            // Get effective 3‑D formatting data
            Aspose.Slides.IThreeDFormatEffectiveData threeDEffective = shape.ThreeDFormat.GetEffective();

            // Display effective 3‑D properties
            Console.WriteLine("=== Effective 3‑D Properties ===");
            Console.WriteLine("Depth: " + threeDEffective.Depth);
            Console.WriteLine("Contour Width: " + threeDEffective.ContourWidth);
            Console.WriteLine("Material: " + threeDEffective.Material);
            Console.WriteLine("Extrusion Height: " + threeDEffective.ExtrusionHeight);
            Console.WriteLine("Contour Color: " + threeDEffective.ContourColor);
            Console.WriteLine("Extrusion Color: " + threeDEffective.ExtrusionColor);

            // Bevel information
            if (threeDEffective.BevelTop != null)
            {
                Console.WriteLine("Top Bevel Type: " + threeDEffective.BevelTop.BevelType);
                Console.WriteLine("Top Bevel Height: " + threeDEffective.BevelTop.Height);
                Console.WriteLine("Top Bevel Width: " + threeDEffective.BevelTop.Width);
            }

            if (threeDEffective.BevelBottom != null)
            {
                Console.WriteLine("Bottom Bevel Type: " + threeDEffective.BevelBottom.BevelType);
                Console.WriteLine("Bottom Bevel Height: " + threeDEffective.BevelBottom.Height);
                Console.WriteLine("Bottom Bevel Width: " + threeDEffective.BevelBottom.Width);
            }

            // Camera and Light Rig
            if (threeDEffective.Camera != null)
            {
                Console.WriteLine("Camera: " + threeDEffective.Camera);
            }

            if (threeDEffective.LightRig != null)
            {
                Console.WriteLine("Light Rig: " + threeDEffective.LightRig);
            }

            // Get effective effect formatting data
            Aspose.Slides.IEffectFormatEffectiveData effectEffective = shape.EffectFormat.GetEffective();

            // Display effective effect properties
            Console.WriteLine("=== Effective Effect Properties ===");
            Console.WriteLine("Is No Effects: " + effectEffective.IsNoEffects);

            // Save the presentation before exiting
            string outputPath = "output.pptx";
            presentation.Save(outputPath, SaveFormat.Pptx);

            // Clean up
            presentation.Dispose();
        }
    }
}