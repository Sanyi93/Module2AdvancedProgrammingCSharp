// See https://aka.ms/new-console-template for more information

//Serilog & Serilog.Sinks.Console wurde installiert
using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using LoggingAssignment;
using ILogger = Microsoft.Extensions.Logging.ILogger;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    //.WriteTo.File("myLog.txt")
    .CreateLogger();

var serviceProvider = new ServiceCollection()
    //.AddLogging(static configure => configure.AddSerilog())
    .AddSingleton<DataProcessingService>()
    .AddSingleton<IDataProcessor, UserInputProcessor>()
    .AddSingleton<ILogger, CustomLogger>()
    .AddSingleton<ExceptionService>()
    .BuildServiceProvider();

var logger = serviceProvider.GetService<ILogger<Program>>();
var dataProcessingService = serviceProvider.GetService<DataProcessingService>();
var exceptionService = serviceProvider.GetService<ExceptionService>();

try
{
    //Sample of CONSOLE & FILE logging
    dataProcessingService.ProcessAndDisplay("Hello world!");

    //Sample of CUSTOM logging
    var customLogger = serviceProvider.GetService<ILogger>();
    customLogger.LogInformation("This is just a custom log");

    //Sample of EXCEPTION logging
    throw new InvalidOperationException("Simulated exception");
}
catch(Exception ex)
{
    exceptionService.HandleException(ex);
}
finally
{
    Log.CloseAndFlush();
}


