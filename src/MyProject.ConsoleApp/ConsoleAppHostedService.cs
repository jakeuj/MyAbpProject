using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProject.Application;
using Serilog;
using Volo.Abp;

namespace MyProject.ConsoleApp;

public class ConsoleAppHostedService : IHostedService
{
    private IAbpApplicationWithInternalServiceProvider _abpApplication;

    private readonly IConfiguration _configuration;
    private readonly IHostEnvironment _hostEnvironment;

    public ConsoleAppHostedService(IConfiguration configuration, IHostEnvironment hostEnvironment)
    {
        _configuration = configuration;
        _hostEnvironment = hostEnvironment;
    }

public async Task StartAsync(CancellationToken cancellationToken)
{
    _abpApplication =  await AbpApplicationFactory.CreateAsync<ConsoleAppModule>(options =>
    {
        options.Services.ReplaceConfiguration(_configuration);
        options.Services.AddSingleton(_hostEnvironment);

        options.UseAutofac();
        options.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog());
        
        options.Services.AddTransient<IHelloWorldAppService,HelloWorldAppService>();
    });

    await _abpApplication.InitializeAsync();

    var helloWorldService = _abpApplication.ServiceProvider.GetRequiredService<IHelloWorldAppService>();
    await helloWorldService.SayHelloAsync();
}

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await _abpApplication.ShutdownAsync();
    }
}
