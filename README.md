# MyAbpProject

[https://www.dotblogs.com.tw/jakeuj/2022/02/11/abp-console](https://www.dotblogs.com.tw/jakeuj/2022/02/11/abp-console)
```
Host terminated unexpectedly!
System.NullReferenceException: Object reference not set to an instance of an object.
   at Volo.Abp.Application.Services.ApplicationService.get_Logger()
   at MyProject.Application.HelloWorldService.SayHelloAsync() in D:\repos\MyAbpProject\src\MyProject.Application\HelloWorldService.cs:line 10
   at MyProject.ConsoleApp.ConsoleAppHostedService.StartAsync(CancellationToken cancellationToken) in D:\repos\MyAbpProject\src\MyProject.ConsoleApp\ConsoleAppHostedService.cs:line 39
   at Microsoft.Extensions.Hosting.Internal.Host.StartAsync(CancellationToken cancellationToken)
   at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
   at Microsoft.Extensions.Hosting.HostingAbstractionsHostExtensions.RunAsync(IHost host, CancellationToken token)
   at Program.<Main>$(String[] args) in D:\repos\MyAbpProject\src\MyProject.ConsoleApp\Program.cs:line 27

Process finished with exit code 1.
```
