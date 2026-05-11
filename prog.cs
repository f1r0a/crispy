#!/usr/bin/env dotnet

// This is a file-based C# program, self-contained in a single .cs file.
// You can place this file in any folder, no .sln or .csproj file is required.

// .NET / dotnet CLI features:
// - Reference NuGet packages:     #:package Spectre.Console@0.53.0
// - Specify the target SDK:       #:sdk Microsoft.NET.Sdk.Web
// - Add shebang for Unix shells:  #!/usr/bin/env dotnet

// Rider-specific features:
// - Syntax highlighting for C# code and SDK/package directives
// - Run and debug using gutter icons
// TODO make it better 
// todo 
#:package Spectre.Console@0.53.0


using Spectre.Console;
var today = DateTime.Today;
AnsiConsole.MarkupLineInterpolated($"[#FFA500]⚠[/] [yellow]3 warnings[/] in ");
AnsiConsole.MarkupLine("[green]✓ Build completed successfully[/]");
AnsiConsole.Markup("Hello [yellow]:waving_hand:[/]!");
var name = AnsiConsole.Ask<string>("What's your [green]name[/]? 😀");

AnsiConsole.MarkupLine($"Welcome, [blue]{name}[/]!");
AnsiConsole.Status()
    .Start("Connecting to server...", ctx => { Thread.Sleep(1000); });

AnsiConsole.Write(new Calendar(today.Year, today.Month)
    .RoundedBorder()
    .HighlightStyle(Style.Parse("red"))
    .HeaderStyle(Style.Parse("yellow"))
    .AddCalendarEvent("Today", today.Year, today.Month, today.Day));