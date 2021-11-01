using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using TestAssignment.Models.DataInterfaces;

namespace TestAssigment.Models.ControllerResultObjects
{
    public class PostPageData : IPostPageData
    {

        private IPostData postInfo;

        private IEnumerable<IPostItem> postItems;

        private IEnumerable<IComment> comments;

        public IPostData PostInfo { get => postInfo; set => postInfo = value; }
        public IEnumerable<IPostItem> PostItems { get => postItems; set => postItems = value; }
        public IEnumerable<IComment> Comments { get => comments; set => comments = value; }
    }
}
