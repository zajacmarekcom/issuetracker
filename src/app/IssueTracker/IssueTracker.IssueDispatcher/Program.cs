using System.Text.Json.Serialization;
using IssueTracker.IssueDispatcher.Requests;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var app = builder.Build();

app.MapPost("/api/issue", async ([FromBody] IssueRequest request) =>
{
    Console.WriteLine(request.Title);
});

app.Run();