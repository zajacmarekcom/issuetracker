# Project overview

## Table of contents

## Purpose of the project

Issue Tracker is a demo project which shows how to design, build and run ASP.NET Core + Blazor project with real requirements.

It's a demo used in videos on [Marek Zając's Youtube Channel](https://www.youtube.com/@zajacmarek).

## High level requirements

### Functional requirements

- Issue dashboard
- Collecting issues by .NET library
- Collecting issues from users, by Blazor library
- Integration with Azure Active Directory
- Managing issues in support team

### Non-functional requirements

- Build with .NET stack
- Hosted in Docker
- Up to 500 incomming issues per second
- One-command run

## Technology

Key technologies and libraries used in Issue Tracker:

- .NET 7
- ASP.NET Core 7
- Blazor WASM
- Entity Framework Core
- MudBlazor
- Docker
- MassTransit
- Event Hub/RabbitMQ
- SignalR
- Mediatr