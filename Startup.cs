using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp29
{
    class Startup : FunctionsStartup

    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<>();
            throw new NotImplementedException();
        }
    }
}
