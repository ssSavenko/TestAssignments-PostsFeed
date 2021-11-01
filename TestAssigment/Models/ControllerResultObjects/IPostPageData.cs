using System.Collections.Generic;
using TestAssignment.Models.DataInterfaces;

namespace TestAssigment.Models.ControllerResultObjects
{
    public interface IPostPageData
    {
        public IPostData PostInfo { get; set; }
        public IEnumerable<IPostItem> PostItems { get; set; }
        public IEnumerable<IComment> Comments { get; set; } 
    }
}
