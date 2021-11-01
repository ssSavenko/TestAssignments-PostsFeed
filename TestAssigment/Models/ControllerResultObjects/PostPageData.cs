using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssigment.Models.DAL;

namespace TestAssigment.Models.ControllerResultObjects
{
    public class PostPageData : IPostPageData
    {

        private DbPostData postInfo;

        private IEnumerable<DbPostItem> postItems;

        private IEnumerable<DbComments> comments;

        public DbPostData PostInfo { get => postInfo; set => postInfo = value; }
        public IEnumerable<DbPostItem> PostItems { get => postItems; set => postItems = value; }
        public IEnumerable<DbComments> Comments { get => comments; set => comments = value; }
    }
}
