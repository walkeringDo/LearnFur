using Fur;
using Fur.DatabaseAccessor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.EntituFramework.Core
{
    public class MyDbStartup:AppStartup
    {
        public void RegisterDb(IServiceCollection service)
        {
            service.AddDatabaseAccessor(option=> {
                option.AddDb<SqliteDbContext>(DbProvider.Sqlite);
            }, "My.Database.Migrations");
        }
    }
}
