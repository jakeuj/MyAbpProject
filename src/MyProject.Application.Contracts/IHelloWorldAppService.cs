using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MyProject;

public interface IHelloWorldAppService:IApplicationService
{
    Task SayHelloAsync();
}