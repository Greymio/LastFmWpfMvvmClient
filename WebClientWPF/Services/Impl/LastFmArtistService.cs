using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebClientWPF.Models;

namespace WebClientWPF.Services.Impl
{
    public class LastFmArtistService : IArtistService
    {
        public ArtistSearch Search(string query)
        {
            string url = $"http://ws.audioscrobbler.com/2.0/?method=artist.search&artist={query}&api_key=2595aa190cb802ea76531f1ba9913a0f&format=json";
            return JsonConvert.DeserializeObject<ArtistSearch>(GetRequest(url));
        }

        public ArtistInfo GetInfo(string mbid)
        {
            string url = $"http://ws.audioscrobbler.com/2.0/?method=artist.getinfo&mbid={mbid}&api_key=2595aa190cb802ea76531f1ba9913a0f&format=json";
            return JsonConvert.DeserializeObject<ArtistInfo>(GetRequest(url));
        }

        private string GetRequest(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }
    }
}
