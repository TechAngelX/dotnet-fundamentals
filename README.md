# dotnet-fundamentals

This repository serves as a central location for backend development projects using the .NET ecosystem. It is structured as a monorepo to accommodate various exercises, APIs, and microservices.

## Repository Structure
To maintain a scalable workspace, the repository uses a clean directory layout:

* **src/**: Contains the source code for all individual projects.
    * **web-api-fundamentals**: An exploration of ASP.NET Core Minimal APIs and the web hosting model.
* **dotnet-fundamentals.sln**: The primary solution file used to manage all projects within this workspace.

## Prerequisites
* .NET SDK (version 8.0 or later)
* Visual Studio Code
* C# Dev Kit extension

## Local Development
To execute a project with hot reload enabled, run the following command from the root directory:

```bash
dotnet watch run --project src/web-api-fundamentals
