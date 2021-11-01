using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssigment.Models.DAL;

namespace TestAssigment.Models.ControllerResultObjects
{
    public interface IPostPageData
    {
        public DbPostData PostInfo { get; set; }
        public IEnumerable<DbPostItem> PostItems { get; set; }
        public IEnumerable<DbComments> Comments { get; set; } 
    }
}
