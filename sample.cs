using System.Diagnostics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

// Define some important constants and the activity source
var serviceName = "MyCompany.MyProduct.MyService";
var serviceVersion = "1.0.0";

var builder = WebApplication.CreateBuilder(args);

// Configure important OpenTelemetry settings, the console exporter, and automatic instrumentation
builder.Services.AddOpenTelemetryTracing(b =>
{
    b
    .AddConsoleExporter()
    .AddSource(serviceName)
    .SetResourceBuilder(
        ResourceBuilder.CreateDefault()
            .AddService(serviceName: serviceName, serviceVersion: serviceVersion))
    .AddHttpClientInstrumentation()
    .AddAspNetCoreInstrumentation();
});

var app = builder.Build();

var httpClient = new HttpClient();

app.MapGet("/hello", async () =>
{
    var html = await httpClient.GetStringAsync("https://example.com/");
    if (string.IsNullOrWhiteSpace(html))
    {
        return "Hello, World!";
    }
    else
    {
        return "Hello, World!";
    }
});

app.Run();
