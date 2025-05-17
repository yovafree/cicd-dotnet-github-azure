using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StarWars.MVC.Models
{
    public class StarWarsMovie
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("opening_crawl")]
        public string OpeningCrawl { get; set; }

        [JsonPropertyName("director")]
        public string Director { get; set; }

        [JsonPropertyName("producer")]
        public string Producer { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("episode_id")]
        public int EpisodeId { get; set; }
    }
}
