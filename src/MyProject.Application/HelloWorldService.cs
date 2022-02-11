using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace MyProject.Application;

public class HelloWorldService : MyProjectAppService
{
    public Task SayHelloAsync()
    {
        Logger.LogInformation("Hello World!");
        return Task.CompletedTask;
    }
}
