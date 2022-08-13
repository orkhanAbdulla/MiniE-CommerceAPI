
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceApi.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductServices>();
        }
    }
}
