using Newtonsoft.Json; 
using System.Collections.Generic; 
namespace Init.ParseModel{ 

    public class Root
    {
        [JsonProperty("DbPostData")]
        public List<PostData> DbPostData;

        [JsonProperty("DbPostItem")]
        public List<PostItem> DbPostItem;

        [JsonProperty("DbComments")]
        public List<Comment> DbComments;
    }

}