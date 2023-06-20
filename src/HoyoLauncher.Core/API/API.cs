﻿namespace HoyoLauncher.Core.API;

public sealed class RetrieveAPI
{
    public string LatestVersion { get; private set; } = "CONNECTION FAILURE, PLEASE RETRY AGAIN";
    public string BackgroundHASH { get; private set; } = "";
    public ImageBrush BackgroundLINK { get; set; } = null;

    readonly JsonElement Resources;
    readonly JsonElement Content;

    public static async Task<RetrieveAPI> Fetch(string CONTENT, string RESOURCES)
    {
        using Stream
        ContentStreamData = await CheckVersion(CONTENT),
        ResourcesStreamData = await CheckVersion(RESOURCES);

        return new(ReadJsonData(ContentStreamData).RootElement, ReadJsonData(ResourcesStreamData).RootElement);
    }

    private RetrieveAPI(JsonElement _Content, JsonElement _Resources)
    {
        Content = _Content;
        Resources = _Resources;
        SetAPIValues();
    }
    
    void SetAPIValues() 
    {
        if(Resources.TryGetProperty("data", out JsonElement VersionProperty))
            LatestVersion = VersionProperty.GetProperty("game").GetProperty("latest").GetProperty("version").ToString();
        
        if(Content.TryGetProperty("data", out JsonElement ContentProperty))
        {
            var adv = ContentProperty.GetProperty("adv");

            BackgroundHASH = adv.GetProperty("bg_checksum").ToString();
            BackgroundLINK = new ImageBrush(new BitmapImage(new(adv.GetProperty("background").ToString())));
        }
    }

    static JsonDocument ReadJsonData(Stream stream)
    {
        using StreamReader DataStream = new(stream, Encoding.UTF8);
        string DataJSON = stream != Stream.Null ? DataStream.ReadToEnd() : "{}";
        return JsonDocument.Parse(DataJSON);
    }
    static async Task<Stream> CheckVersion(string APILink)
    {
        HttpResponseMessage resp;

        try
        {
            using (HttpClient req = new(handler: new HttpClientHandler() { Proxy = null }))
            {
                req.Timeout = TimeSpan.FromMilliseconds(800);
                req.DefaultRequestVersion = HttpVersion.Version30;
                req.DefaultRequestHeaders.Add("User-Agent", "VersionCheck");
                var res = req.GetAsync(APILink).Result;
                resp = res;
            }

            return await resp.Content.ReadAsStreamAsync();
        }
        catch { return Stream.Null; }
    }
}