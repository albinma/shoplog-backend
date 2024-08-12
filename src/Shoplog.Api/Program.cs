using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    Log.Information("Starting web host");

    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddSerilog(
        (services, configuration) =>
            configuration
                .ReadFrom.Configuration(builder.Configuration)
                .ReadFrom.Services(services)
                .Enrich.FromLogContext()
    );

    builder.Services.AddDbContextPool<VpicDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"))
    );

    builder.Services.AddCors();
    builder.Services.AddControllers();

    var app = builder.Build();
    app.UseSerilogRequestLogging();
    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
