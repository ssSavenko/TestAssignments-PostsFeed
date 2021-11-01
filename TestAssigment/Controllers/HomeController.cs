using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestAssigment.Models.DAL;
using TestAssigment.Models.ControllerResultObjects;

namespace TestAssigment.Controllers
{
    [ApiController]
    [Route("Home")] 
    public class HomeController : Controller
    {
        DatabseContext context;
        private const int dataPerPage = 3;

        public HomeController(  DatabseContext context)
        {
            this.context = context; 
        }

        [HttpGet]
        public IPostsFeed Get(uint page = 0)
        {
            IPostsFeed resultItem = new PostsFeed();
            List<DbPostData> postsData = postsData = context.PostsData.OrderBy(postsData => postsData.PageNum).ToList();
             
            if (page * dataPerPage < postsData.Count && postsData.Count > 0)
            {
                int index = (int)page;
                int count = dataPerPage;
                if (page > 0)
                    resultItem.HasPrev = true;

                if ((page+1)* dataPerPage < postsData.Count) 
                    resultItem.HasNext = true;
                else
                    count = postsData.Count-index* dataPerPage;

                resultItem.ResultList = postsData.GetRange(index * dataPerPage, count);
            }


            return resultItem;
        }
    }
}
