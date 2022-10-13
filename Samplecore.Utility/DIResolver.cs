using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Samplecore.Core.IRepository;
using Samplecore.Core.Iservices;
using Samplecore.Repository;
using Samplecore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samplecore.Utility
{
   public class DIResolver
    {
        public static void ConfigureServices(IServiceCollection Services)
        {
            //for accessing the http context by interface in view level
            #region Http context
            Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion
            //for service accesssing
            #region Service

            Services.AddScoped<IEmployeeService, EmployeeServices>();
            #endregion
            //for database accessing 
            #region Repository

            Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            #endregion

        }
    }
}
