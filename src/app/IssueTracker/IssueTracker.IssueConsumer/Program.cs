using System.Text.Json.Serialization;
using IssueTracker.IssueConsumer.Queue;
using MassTransit;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services
    .ConfigureHttpJsonOptions(options => { options.SerializerOptions.Converters.Add(new JsonStringEnumConverter()); })
    .AddMassTransit(options =>
    {
        options.UsingRabbitMq(
            (ctx, config) =>
            {
                config.ReceiveEndpoint("issue-queue", e => { e.Consumer<NewIssueMessageHandler>(); });
            });
    })
    .AddMediatR(config => config.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

app.Run();