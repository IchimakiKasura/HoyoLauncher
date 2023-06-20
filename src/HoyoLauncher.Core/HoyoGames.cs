﻿namespace HoyoLauncher.Core;

public sealed class HoyoGames
{
    public string GAME_DIRECTORY { get; private set; }
    public bool GAME_DIR_VALID { get; set; } = false;
    public string GAME_EXECUTABLE { get; }
    public string GAME_NAME { get; }
    public string GAME_HOMEPAGE { get; }
    public string GAME_CHECK_IN_PAGE { get; }
    public ImageBrush GAME_DEFAULT_BG { get; }
    public string GAME_RESOURCE_API_LINK { get; }
    public string GAME_CONTENT_API_LINK { get; }
    public string GAME_MAP_PAGE { get; }

    public RetrieveAPI API_CACHE { get; set; }

    private HoyoGames(
        string GameDirectory,
        string GameExecutable,
        string GameName,
        string GameHomepage,
        string GameCheckInPage,
        ImageBrush GameDefaultBG,
        string GameApiLink,
        string GameBGapi,
        string Gamemappage
        )
    {
        GAME_DIRECTORY = GameDirectory;
        GAME_EXECUTABLE = GameExecutable;
        GAME_NAME = GameName;
        GAME_HOMEPAGE = GameHomepage;
        GAME_CHECK_IN_PAGE = GameCheckInPage;
        GAME_DEFAULT_BG = GameDefaultBG;
        GAME_RESOURCE_API_LINK = GameApiLink;
        GAME_CONTENT_API_LINK = GameBGapi;
        GAME_MAP_PAGE = Gamemappage;
    }

    public readonly static HoyoGames DEFAULT =
        new("","", "", "https://www.hoyoverse.com/en-us/","",null,"","","");

    public readonly static HoyoGames GenshinImpact =
        new
        (
            AppSettings.Settings.Default.GENSHIN_IMPACT_DIR,
            Games.GENSHIN_IMPACT_EXEC,
            Games.GENSHIN_IMPACT_TITLE,
            "https://genshin.hoyoverse.com/en",
            "https://act.hoyolab.com/ys/event/signin-sea-v3/index.html?act_id=e202102251931481",
            DefaultBG.GENSHIN_BG,
            AppSettings.Settings.Default.GENSHIN_VERSION_API,
            AppSettings.Settings.Default.GENSHIN_CONTENT_API,
            "https://act.hoyolab.com/ys/app/interactive-map/index.html"
        );

    public readonly static HoyoGames HonkaiStarRail =
        new
        (
            AppSettings.Settings.Default.HONKAI_STAR_RAIL_DIR,
            Games.HONKAI_STAR_RAIL_EXEC,
            Games.HONKAI_STAR_RAIL_TITLE,
            "https://hsr.hoyoverse.com/en-us/",
            "https://act.hoyolab.com/bbs/event/signin/hkrpg/index.html?act_id=e202303301540311",
            DefaultBG.HSR_BG,
            AppSettings.Settings.Default.HSR_VERSION_API,
            AppSettings.Settings.Default.HSR_CONTENT_API,
            "https://act.hoyolab.com/sr/app/interactive-map/index.html"
        );

    public readonly static HoyoGames HonkaiImpactThird =
        new
        (
            AppSettings.Settings.Default.HONKAI_IMPACT_THIRD_DIR,
            Games.HONKAI_IMPACT_THIRD_EXEC,
            Games.HONKAI_IMPACT_THIRD_TITLE,
            "https://honkaiimpact3.hoyoverse.com/global/en-us/fab",
            "https://act.hoyolab.com/bbs/event/signin-bh3/index.html?act_id=e202110291205111",
            DefaultBG.HI3_BG,
            AppSettings.Settings.Default.HI3_VERSION_API,
            AppSettings.Settings.Default.HI3_CONTENT_API,
            ""
        );

    public readonly static HoyoGames ZenlessZoneZero =
        new
        (
            AppSettings.Settings.Default.ZENLESS_ZONE_ZERO_DIR,
            "",
            "",
            "https://zenless.hoyoverse.com/en-us",
            "",
            DefaultBG.ZZZ_BG,
            "",
            "",
            ""
        );

    public readonly static HoyoGames TearsOfThemis =
        new
        (
            "https://play.google.com/store/apps/details?id=com.miHoYo.tot.glb",
            "",
            "",
            "https://tot.hoyoverse.com/en-us",
            "",
            null,
            "",
            "",
            ""
        );

    public static void RefreshDirectory()
    {
        GenshinImpact.GAME_DIRECTORY = AppSettings.Settings.Default.GENSHIN_IMPACT_DIR;
        HonkaiStarRail.GAME_DIRECTORY = AppSettings.Settings.Default.HONKAI_STAR_RAIL_DIR;
        HonkaiImpactThird.GAME_DIRECTORY = AppSettings.Settings.Default.HONKAI_IMPACT_THIRD_DIR;
    }
}