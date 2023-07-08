using IssueTracker.IssueDispatcher.Requests;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateSlimBuilder(args);

var app = builder.Build();

app.MapPost("/", async ([FromBody] IssueRequest request) =>
{

});

app.Run();