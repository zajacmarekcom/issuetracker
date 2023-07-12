using System.Text.Json.Serialization;
using IssueTracker.IssueDispatcher.Requests;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using IMediator = MediatR.IMediator;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services
    .ConfigureHttpJsonOptions(options => { options.SerializerOptions.Converters.Add(new JsonStringEnumConverter()); })
    .AddMassTransit(options => { options.UsingRabbitMq(); })
    .AddMediatR(config => config.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddScoped<NewIssueCommandHandler>();

var app = builder.Build();

app.MapPost("/api/issue",
    async ([FromBody] NewIssueCommand request, IMediator mediator) => await mediator.Send(request));

app.Run();