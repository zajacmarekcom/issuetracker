# Project overview

## Table of contents

- Architecture
    - [Modules](./docs/architecture/modules.md)
- Features
    - [Issue](./docs/features/issue.md)

## Purpose of the project

Issue Tracker is a demo project which shows how to design, build and run ASP.NET Core + Blazor project with real requirements.

It's a demo used in videos on [Marek Zając's Youtube Channel](https://www.youtube.com/@zajacmarek).

## High level requirements

### Functional requirements

- Issue dashboard
- Collecting issues by .NET library
- Collecting issues from users, by Blazor library
- Managing issues in support team
- Sending notifications by email
- Integration with Azure Active Directory
- API Key based access

### Non-functional requirements

- Build with .NET stack
- Hosted in Docker
- Up to 500 incomming issues per second
- One-command run
- MinimalAPI
- gRPC & REST API
- Single-tenant instance
- Up to 100 mln issues in database
- 99.99% availability
- Secured access

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