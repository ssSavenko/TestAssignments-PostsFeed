using Newtonsoft.Json; 
namespace Init.ParseModel{ 

    public class PostData
    {
        [JsonProperty("Id")]
        public string Id;

        [JsonProperty("Name")]
        public string Name;

        [JsonProperty("Overview")]
        public string Overview;
          
        [JsonProperty("Icon")]
        public byte[] Icon;
    }

}