using Init.ParseModel;
using Newtonsoft.Json;
using System;
using TestAssigment.Models.DAL;

namespace TestAssignment.Init
{
    public class InitDB
    { 
        public InitDB(DatabseContext context)
        {
            Root jObject = JsonConvert.DeserializeObject<Root>(System.IO.File.ReadAllText("Init/InitData.json"));

            foreach (var postData in jObject.DbPostData)
            {
                DbPostData newItem = new DbPostData();
                newItem.Id = new Guid(postData.Id);
                newItem.Name = postData.Name;
                newItem.Overview = postData.Overview;
                newItem.Icon = postData.Icon;
                context.PostsData.Add(newItem);
                context.SaveChanges();
            }

            foreach (var postItems in jObject.DbPostItem)
            {
                DbPostItem newItem = new DbPostItem(); 
                newItem.Image = postItems.Image;
                newItem.Text = postItems.Text;
                newItem.NumberOfPostItem = postItems.NumberOfPostItem;
                newItem.IsHorizontal = postItems.IsHorizontal;
                newItem.PostId = new Guid(postItems.PostId);
                context.PostItem.Add(newItem);
            }
            foreach (var postData in jObject.DbComments)
            {
                DbComments newItem = new DbComments();
            }
            context.SaveChanges();
        }
    }
}
