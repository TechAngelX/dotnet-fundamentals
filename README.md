# dotnet-fundamentals

This repository serves as a central location for my backend development test projects using the .NET ecosystem. It is structured as a monorepo to accommodate various exercises, APIs, and microservices.

## Repository Structure
To maintain a scalable workspace, the repository uses a clean directory layout:

* **src/**: Contains the source code for all individual projects.
    * **web-api-fundamentals**: An exploration of ASP.NET Core Minimal APIs and the web hosting model.
* **dotnet-fundamentals.sln**: The primary solution file used to manage all projects within this workspace.

## Prerequisites
* .NET SDK (version 8.0 or later)
* C# Dev Kit extension

## Local Development
To execute a project with hot reload enabled, run the following command from the root directory:

```bash
dotnet watch run --project src/web-api-fundamentals
```

## License

© Ricki Angel 2026 | TechAngelX
Internal use only.


## Disclaimer

This tool is for personal or educational use only and comes without any warranty.
***
<h2 style="text-align: center;">Support</h2>
<div align="center">
  <span style="font-size: 1.4em; font-weight: 300;">
    For issues or questions, feel free to reach out to me on GitHub.
  </span>
  <br /><br />
  <a href="https://techangelx.com" target="_blank" rel="noopener noreferrer">
    <img src="./readme_images/logo.png" alt="Tech Angel X Logo" width="70" height="70" style="vertical-align: middle; border-radius: 50%; border: 4px solid #ffffff; box-shadow: 0 4px 10px rgba(0,0,0,0.2);">
  </a>
  <br /><br />
  <span style="font-size: 1.4em; font-weight: 300;">
    <b>Built by Ricki Angel</b> • <a href="https://techangelx.com" target="_blank" rel="noopener noreferrer" style="text-decoration: none;">Tech Angel X</a>
  </span>
</div>
