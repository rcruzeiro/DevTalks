using Microsoft.Extensions.DependencyInjection;

namespace IoCExamples
{
    public class ContainerService
    {
        readonly IServiceCollection _services;

        public ContainerService()
        {
            _services = new ServiceCollection();

            // container lifetime
            _services.AddTransient<ICustomerDataAccess, CustomerDataAccess>();

            // other lifetimes
            //_services.AddScoped<>();
            //_services.AddSingleton<>();
        }
    }
}
