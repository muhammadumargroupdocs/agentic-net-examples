using System;
using System.Collections.Generic;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string inputPath = "input.pptx";
            string outputPath = "output_no_comments.pptx";

            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                List<Aspose.Slides.IComment> commentsToRemove = new List<Aspose.Slides.IComment>();

                foreach (Aspose.Slides.ICommentAuthor author in presentation.CommentAuthors)
                {
                    foreach (Aspose.Slides.IComment comment in author.Comments)
                    {
                        commentsToRemove.Add(comment);
                    }
                }

                foreach (Aspose.Slides.IComment comment in commentsToRemove)
                {
                    comment.Remove();
                }

                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}