using CurrentTimeModel;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ITime, TimeUTC>();
var app = builder.Build();

app.MapGet("/current_utc_time", (ITime time, int? hour, int? minute) => 
    $"Текущее время {time.GetCurrentUTCTime(hour, minute).ToShortTimeString()}"
    );

app.Run();


