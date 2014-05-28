using LOL.Common.DTO;
using LOL.Common.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LOL.Common.API
{
    public class SummonersApi
    {
        public string ApiKey { get; set; }

        public string Region { get; set; }

        public SummonersApi()
        {
            throw new Exception("You should always call the summoners api with an api key and the region");
        }

        public SummonersApi(string apiKey, string region)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException("KRAPP");
            }

            if (string.IsNullOrWhiteSpace(region))
            {
                throw new ArgumentException("KRAPP");
            }

            this.ApiKey = apiKey;
            this.Region = region;
        }

        public async Task<ICollection<ChampionDTO>> Get()
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(60);
                client.MaxResponseContentBufferSize = 1000000000;
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                string address = UrlHelpers.GetAllChampionsUrl(this.Region, this.ApiKey);
                var responseMessage = client.GetStringAsync(new Uri(address)).Result;

                return JsonConvert.DeserializeObject<ICollection<ChampionDTO>>(responseMessage);
            }
        }
        // TODO: KRAPP CHECK FOR ERROR CODES FROM LOL
        public async Task<ChampionDTO> Get(long championId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(10);
                client.MaxResponseContentBufferSize = 10000000;

                string address = UrlHelpers.GetSingleChampionUrl(this.Region, this.ApiKey, championId);
                var responseMessage = await client.GetAsync(new Uri(address));
                return JsonConvert.DeserializeObject<ChampionDTO>(responseMessage.Content.ToString());
            }
        }
    }
}
