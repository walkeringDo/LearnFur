using Fur.DatabaseAccessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Core.Entites
{
    public class Person:Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
