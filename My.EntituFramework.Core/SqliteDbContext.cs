using Fur.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.EntituFramework.Core
{
    [AppDbContext("Sqlitedb")]
    public class SqliteDbContext:AppDbContext<SqliteDbContext>
    {
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options):base(options)
        {

        }
    }
}
