
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAssigment.Models.DAL;
using TestAssigment.Models.ControllerResultObjects;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json.Linq; 

namespace TestAssigment.Controllers
{
    [ApiController]
    [Route("Home/Post/{postNumber}")] 
    public class PostController
    { 
        DatabseContext context;

        public PostController(DatabseContext context)
        {
            this.context = context;
            
        }

        [HttpGet]
        public IPostPageData Get(uint postNumber)
        {
            DbPostData postInfo = context.PostsData.FirstOrDefault(item => item.PageNum ==  postNumber);
            List<DbPostItem> postItems = context.PostItem?.Where(item => item.PostId == postInfo.Id)?.OrderBy(item => item.NumberOfPostItem)?.ToList();
            List<DbComments> comments = context.Comments?.Where(item => item.PostsId == postInfo.Id)?.OrderBy(item => item.CreatedOn)?.ToList();

            IPostPageData result = new PostPageData();
            result.PostInfo = postInfo;
            result.PostItems = postItems;
            result.Comments = comments;

            return result;
        }

        [HttpPost]
        public void Post(dynamic postData)
        {
            try
            {
                JObject jPostData = JToken.Parse(postData.ToString());
                string name = (string)jPostData["name"];
                string message = (string)jPostData["message"];
                int postsNumber = (int)jPostData["postsNum"];
                DbComments newComment = new DbComments();
                newComment.UsersName = name;
                newComment.Text = message;
                newComment.PostsId = context.PostsData.FirstOrDefault(item => item.PageNum == postsNumber).Id;
                context.Comments.Add(newComment);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                //logger place
                throw e;
            }
        }
    }
}
