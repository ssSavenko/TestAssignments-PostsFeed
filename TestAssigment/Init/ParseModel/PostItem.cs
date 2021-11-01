using Newtonsoft.Json; 
namespace Init.ParseModel{ 

    public class PostItem
    {
        [JsonProperty("PostId")]
        public string PostId;

        [JsonProperty("Image")]
        public byte[] Image;

        [JsonProperty("isHorizontal")]
        public bool IsHorizontal;

        [JsonProperty("NumberOfPostItem")]
        public int NumberOfPostItem;

        [JsonProperty("Text")]
        public string Text;
    }

}