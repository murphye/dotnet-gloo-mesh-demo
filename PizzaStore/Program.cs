using Microsoft.OpenApi.Models;
using OpenTelemetry;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
  {
      c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pizza Store API", Description = "Keep track of your pizza", Version = "v1" });
  });

builder.Services.AddOpenTelemetryTracing(builder => {
    builder
        .AddHttpClientInstrumentation()
        .AddAspNetCoreInstrumentation();
        //.AddConsoleExporter();
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
  {
     c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
  });

app.MapGet("/", () => 
{
    foreach (var item in Baggage.GetBaggage())
    {
        Console.WriteLine(item.Key + "=" + item.Value);
    }

    return "Hello World!";
})
.WithName("GetHelloWorld");

app.Run();
