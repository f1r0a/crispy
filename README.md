# Crispy

## Overview

`crispy` is a minimal, file-based C# console app that runs directly from a single `prog.cs` script using the `dotnet` CLI (no `.sln`/`.csproj` required).

The current program demonstrates:
- Colored terminal output
- Interactive user input
- A simple status spinner
- Calendar rendering

## Stack

- **Language:** C# (`.NET` file-based app style)
- **Runtime/SDK:** `.NET` (environment indicates `net10.0` availability)
- **Framework type:** C[README.md](README.md)onsole application
- **Primary library:** `Spectre.Console` (`#:package Spectre.Console@0.53.0` in `prog.cs`)
- **Package acquisition:** Inline NuGet package directive in source (resolved by `dotnet` when running script)
- **Package manager:** NuGet via `dotnet`

## Requirements

- `dotnet` SDK installed and available in `PATH`
- A terminal that supports UTF-8/ANSI output (recommended for best Spectre.Console rendering)

> TODO: Confirm and document the minimum required `dotnet` SDK version for this script.

## Entry Point

- `prog.cs` (script-style executable C# file)
- Shebang: `#!/usr/bin/env dotnet`

## Setup & Run

No project restore/build step is required beforehand for this single-file setup.

Run from repo root:

```bash
dotnet run prog.cs
```

You can also run it as an executable script on Unix-like systems (if executable permission is set):

```bash
./prog.cs
```

## Scripts

There is currently no dedicated scripts manifest (for example, no `package.json`, `Makefile`, or custom task runner config).

Available command:
- `dotnet run prog.cs` — execute the application.

## Environment Variables

No project-specific environment variables are currently defined.

> TODO: Add environment variable documentation if configuration is introduced.

## Tests

No **_automated_** test project/files are currently present in this repository.

> TODO: Add tests if/when non-trivial business logic is introduced.

## Project Structure

```text
.
├── prog.cs           # Main file-based C# program (entry point)
├── LICENSE           # Mozilla Public License 2.0
├── README.md         # Project documentation
├── Empty File        # Misc file (purpose currently undocumented)
├── Text File.txt     # Misc file (purpose currently undocumented)
└── Folder.DotSettings.user
```

> TODO: Clarify whether `Empty File`, `Text File.txt`, and `Folder.DotSettings.user` are intentional project artifacts.

## License

This repository is licensed under the **Mozilla Public License 2.0**. See [`LICENSE`](./LICENSE).
