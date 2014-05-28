namespace LOL.Common.Helpers
{
    public static class UrlHelpers
    {
        public static string GetAllChampionsUrl(string region, string apiKey)
        {
            return string.Format(Constants.BaseUri + "/api/lol/{0}/v1.2/champion?api_key={1}", region, apiKey);
        }

        public static string GetSingleChampionUrl(string region, string apiKey, long championId)
        {
            return string.Format(Constants.BaseUri + "/api/lol/{0}/v1.2/champion/{2}?api_key={1}", region, apiKey, championId);
        }
    }
}
