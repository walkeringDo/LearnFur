using Fur.DatabaseAccessor;
using Fur.DynamicApiController;
using My.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.Application
{
    /// <summary>
    /// 
    /// </summary>
    public class PersonAppService:IDynamicApiController
    {
        private readonly IRepository<Person> _reportory;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repository"></param>
        public PersonAppService(IRepository<Person> repository)
        {
            _reportory = repository;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="person"></param>
        public void insert(Person person)
        {
            _reportory.Insert(person);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<Person> GetAll()
        {
            return _reportory.AsEnumerable();
        }
    }
}
