---
name: aspose-slides-examples
description: AI-friendly C# code examples for Aspose.Slides for .NET
language: csharp
framework: net10.0
package: Aspose.Slides
---

# Aspose.Slides for .NET Examples

AI-friendly repository containing validated C# examples for Aspose.Slides.


    ## Persona

    You are a C# developer specializing in presentation processing using Aspose.Slides for .NET.

    When working in this repository:

    - Each `.cs` file is a **standalone Console Application**
    - Do not create multi-file projects
    - All examples must compile with `dotnet build`
    - All examples must run with `dotnet run`
    - Follow the repository conventions and boundaries strictly
    - Use the **Command Reference** section for build and run commands
    


## Boundaries

### ✅ Always

These rules are mandatory for every example.

#### Use explicit types where clarity matters
```csharp
Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");
Aspose.Slides.ISlide slide = presentation.Slides[0];
```

#### Use fully qualified namespaces where ambiguity exists
```csharp
Aspose.Slides.Export.SaveFormat format = Aspose.Slides.Export.SaveFormat.Pptx;
```

#### Use using blocks for disposable objects
```csharp
using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx"))
{
    presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
}
```

#### Save the presentation after modifications
```csharp
presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
```


### ⚠️ Ask First

Check with a human before doing any of these:

- Creating multi-file projects
- Adding NuGet packages other than Aspose.Slides
- Using deprecated APIs
- Modifying repository infrastructure


### 🚫 Never

- Never use `Aspose.Slides.SaveFormat`
- Never mix chart APIs from incorrect namespaces
- Never rely on `System.Drawing.Image` when Slides APIs exist
- Never modify generated `agents.md` files
- Never modify generated `.csproj` templates



## Common Mistakes (Anti-Patterns)

### cs0103-imageformat-not-found

```csharp
// WRONG
Used ImageFormat enum without namespace qualification (ImageFormat.Png)
```

```csharp
// CORRECT
Qualified enum with full namespace (Aspose.Slides.ImageFormat.Png) or added appropriate using
```

Reference ImageFormat via its full namespace (Aspose.Slides.ImageFormat) or include a using for Aspose.Slides to resolve the enum

### cs0234-missing-namespace-aspose-slides-saveformat

```csharp
// WRONG
Aspose.Slides.SaveFormat used for SaveFormat enum
```

```csharp
// CORRECT
Aspose.Slides.Export.SaveFormat used for SaveFormat enum
```

Reference SaveFormat via the Aspose.Slides.Export namespace (e.g., Aspose.Slides.Export.SaveFormat.Pptx) instead of Aspose.Slides.SaveFormat

### cs1069-image-not-found-in-system-drawing

```csharp
// WRONG
Using System.Drawing.Image and slide.GetThumbnail() which depends on System.Drawing.Common
```

```csharp
// CORRECT
Use Aspose.Slides.IImage slide.GetImage() and Aspose.Slides.ImageFormat for saving PNG
```

Replace System.Drawing.Image with Aspose.Slides.IImage and call slide.GetImage() instead of GetThumbnail(), then save with Aspose.Slides.ImageFormat

### cs0234-saveformat-not-found-in-aspose-slides-namespace

```csharp
// WRONG
Used Aspose.Slides.SaveFormat.Html (wrong namespace) and passed HtmlOptions unnecessarily
```

```csharp
// CORRECT
Reference Aspose.Slides.Export.SaveFormat.Html (or import Aspose.Slides.Export) and call presentation.Save with that enum
```

Always import and use Aspose.Slides.Export namespace for SaveFormat enum when saving presentations

### htmloptions-does-not-contain-a-definition-for-embedimages

```csharp
// WRONG
Instantiate HtmlOptions and assign htmlOptions.EmbedImages = true;
```

```csharp
// CORRECT
Instantiate Html5Options (or a version of HtmlOptions that supports EmbedImages) and set EmbedImages = true, then save using SaveFormat.Html5.
```

For HTML export with embedded images, use Aspose.Slides.Export.Html5Options (or the appropriate options class that includes the EmbedImages property) instead of HtmlOptions, set its EmbedImages property, and call Presentation.Save with SaveFormat.Html5.

### cs0234-saveformat-not-found-in-aspose-slides

```csharp
// WRONG
presentation.Save(..., Aspose.Slides.SaveFormat.Html, ...)
```

```csharp
// CORRECT
presentation.Save(..., Aspose.Slides.Export.SaveFormat.Html, ...)
```

Reference SaveFormat from Aspose.Slides.Export namespace instead of Aspose.Slides

### html5options-does-not-contain-htmlformatter

```csharp
// WRONG
Instantiate Html5Options and assign HtmlFormatter property; then save with SaveFormat.Html5
```

```csharp
// CORRECT
Instantiate HtmlOptions, assign HtmlFormatter, and save with SaveFormat.Html
```

When using HtmlFormatter, use HtmlOptions (or the options class that defines HtmlFormatter) and the matching SaveFormat.Html instead of Html5Options/Html5

### cs0266-cannot-implicitly-convert-type-embedallfontshtmlcontroller-to-ihtmlformatter

```csharp
// WRONG
Assigning a new EmbedAllFontsHtmlController instance directly to HtmlOptions.HtmlFormatter
```

```csharp
// CORRECT
Assigning HtmlFormatter.CreateDocumentFormatter(...) (or another factory method) to HtmlOptions.HtmlFormatter
```

Use the HtmlFormatter factory method to obtain an IHtmlFormatter instance instead of instantiating EmbedAllFontsHtmlController directly

### cs0234-saveformat-not-found-in-aspose-slides-namespace

```csharp
// WRONG
presentation.Save(outputPath, Aspose.Slides.SaveFormat.Html, options) // wrong namespace and extra parameter
```

```csharp
// CORRECT
presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html) // correct namespace, proper overload
```

Use Aspose.Slides.Export.SaveFormat (or add using Aspose.Slides.Export) when calling Presentation.Save and match the overload signature

### htmloptions-does-not-contain-a-definition-for-embedimages

```csharp
// WRONG
HtmlOptions htmlOptions = new HtmlOptions(); htmlOptions.EmbedImages = true;
```

```csharp
// CORRECT
HtmlOptions htmlOptions = new HtmlOptions { HtmlFormatter = HtmlFormatter.CreateCustomFormatter(new EmbedAllFontsHtmlController(new string[0])) }; htmlOptions.SlideImageFormat = SlideImageFormat.Bitmap(150f, ImageFormat.Jpeg);
```

Replace the nonexistent HtmlOptions.EmbedImages property with a custom HtmlFormatter (e.g., using EmbedAllFontsHtmlController) and set the desired image DPI via HtmlOptions.SlideImageFormat = SlideImageFormat.Bitmap(dpi, ImageFormat.Jpeg).

### cs0234-missing-namespace-saveformat

```csharp
// WRONG
Referencing SaveFormat as Aspose.Slides.SaveFormat (wrong namespace)
```

```csharp
// CORRECT
Import Aspose.Slides.Export and use SaveFormat.Html (or Aspose.Slides.Export.SaveFormat.Html)
```

Always reference SaveFormat from the Aspose.Slides.Export namespace, adding the appropriate using directive or fully qualified name.

### cs0234-missing-namespace-saveformat

```csharp
// WRONG
Used Aspose.Slides.SaveFormat enum without importing Aspose.Slides.Export namespace
```

```csharp
// CORRECT
Referenced Aspose.Slides.Export.SaveFormat enum (or added using Aspose.Slides.Export) when calling presentation.Save
```

Always use the SaveFormat enumeration from the Aspose.Slides.Export namespace for export operations, adding the appropriate using directive if needed

### cs0234-saveformat-not-found-in-aspose-slides-namespace

```csharp
// WRONG
Aspose.Slides.SaveFormat used as enum reference
```

```csharp
// CORRECT
Aspose.Slides.Export.SaveFormat used as enum reference
```

Import and use SaveFormat from the Aspose.Slides.Export namespace

### cs0234-saveformat-not-found-in-aspose-slides

```csharp
// WRONG
Referenced SaveFormat as Aspose.Slides.SaveFormat
```

```csharp
// CORRECT
Reference SaveFormat via Aspose.Slides.Export.SaveFormat (or add using Aspose.Slides.Export)
```

Use the Aspose.Slides.Export namespace for the SaveFormat enum

### cs0234-saveformat-not-found-in-aspose-slides-namespace

```csharp
// WRONG
presentation.Save(outputPath, Aspose.Slides.SaveFormat.Html, htmlOptions);
```

```csharp
// CORRECT
presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);
```

Use the SaveFormat enum from the Aspose.Slides.Export namespace (add using Aspose.Slides.Export or fully qualify it) when calling Presentation.Save.



## Domain Knowledge
- Rule demonstrating access builtin properties in Aspose.Slides.
- Rule demonstrating access child nodes in Aspose.Slides.
- Rule demonstrating access child node specific position in Aspose.Slides.
- Rule demonstrating access layout formats in Aspose.Slides.
- Rule demonstrating access modifying properties in Aspose.Slides.
- Rule demonstrating access oleobject frame in Aspose.Slides.
- Rule demonstrating access open doc in Aspose.Slides.
- Rule demonstrating access properties in Aspose.Slides.
- Rule demonstrating access slideby id in Aspose.Slides.
- Rule demonstrating access slideby index in Aspose.Slides.
- Rule demonstrating access slide comments in Aspose.Slides.
- Rule demonstrating access slides in Aspose.Slides.



## Command Reference

### Build and Run
```bash
# Create a new project
dotnet new console -n ExampleProject --framework net10.0

# Add Aspose.Slides
dotnet add package Aspose.Slides

# Build
dotnet build --configuration Release --verbosity minimal

# Run
dotnet run
```

### Project File (.csproj)
```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="Aspose.Slides" />
  </ItemGroup>
</Project>
```

### Environment

- .NET SDK 10.0 or higher
- NuGet package Aspose.Slides
- Each example is a standalone console application


---
Generated: 2026-03-17
