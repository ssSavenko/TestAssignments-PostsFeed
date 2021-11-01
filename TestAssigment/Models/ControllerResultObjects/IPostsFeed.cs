using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssigment.Models.DAL;

namespace TestAssigment.Models.ControllerResultObjects
{
    public interface IPostsFeed 
    {
        public IEnumerable<DbPostData> ResultList { get; set; }
        public bool HasNext { get; set; }
        public bool HasPrev { get; set; }
    }
}
