using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssigment.Models.DAL;

namespace TestAssigment.Models.ControllerResultObjects
{
    public class PostsFeed : IPostsFeed
    {
        private bool hasNext = false;

        private bool hasPrev = false;

        private IEnumerable<DbPostData> resultList = null;
         
        public IEnumerable<DbPostData> ResultList
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
