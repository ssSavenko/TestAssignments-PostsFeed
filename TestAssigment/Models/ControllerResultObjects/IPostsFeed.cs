using System.Collections.Generic; 
using TestAssignment.Models.DataInterfaces;

namespace TestAssigment.Models.ControllerResultObjects
{
    public interface IPostsFeed 
    {
        public IEnumerable<IPostData> ResultList { get; set; }
        public bool HasNext { get; set; }
        public bool HasPrev { get; set; }
    }
}
