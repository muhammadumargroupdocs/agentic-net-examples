using System;
using System.Drawing;

namespace SlideCommentsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.ppt";
            string outputPath = "output.ppt";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Access slide comments
            foreach (object authorObj in presentation.CommentAuthors)
            {
                Aspose.Slides.CommentAuthor author = (Aspose.Slides.CommentAuthor)authorObj;

                foreach (object commentObj in author.Comments)
                {
                    Aspose.Slides.Comment comment = (Aspose.Slides.Comment)commentObj;

                    // Output comment details
                    Console.WriteLine("Author: {0} ({1})", author.Name, author.Initials);
                    Console.WriteLine("Slide Number: {0}", comment.Slide.SlideNumber);
                    Console.WriteLine("Text: {0}", comment.Text);
                    Console.WriteLine("Created: {0}", comment.CreatedTime);
                    Console.WriteLine("Position: X={0}, Y={1}", comment.Position.X, comment.Position.Y);
                    Console.WriteLine();
                }
            }

            // Save the presentation in PPT format
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}