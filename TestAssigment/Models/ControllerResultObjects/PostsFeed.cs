 
using System.Collections.Generic;  
using TestAssignment.Models.DataInterfaces;

namespace TestAssigment.Models.ControllerResultObjects
{
    public class PostsFeed : IPostsFeed
    {
        private bool hasNext = false;

        private bool hasPrev = false;

        private IEnumerable<IPostData> resultList = null;
         
        public IEnumerable<IPostData> ResultList
        {
            get { return resultList; }
            set { resultList = value; }
        }

        public bool HasNext
        {
            get { return hasNext; }
            set { hasNext = value; }
        }

        public bool HasPrev
        {
            get { return hasPrev; }
            set { hasPrev = value; }
        }
         
    }
}
