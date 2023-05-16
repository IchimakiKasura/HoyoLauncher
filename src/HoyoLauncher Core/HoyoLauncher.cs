namespace HoyoLauncher.Core;

public sealed class HoyoMain
{
    public static bool FirstRun { get; set; }
    public static bool IsGameRunning { get; set; }
    public static string ExecutableName { get; set; }
    public static HoyoGames CurrentGameSelected { get; set; }

    public static void Initialize()
    {
        AppSettings.Settings.Default.Upgrade();

        bool ErrorOccured = false;

        FirstRun = true;
        CurrentGameSelected = HoyoGames.DEFAULT;
        IsGameRunning = false;

        EventsAttribute.SetEvents();

        List<(ConfigRead config, HoyoGames AbsoluteName, HoyoButton Launcher)> GameConfigs = new()
        {
            (ConfigRead.GetConfig(AppSettings.Settings.Default.GENSHIN_IMPACT_DIR), HoyoGames.GenshinImpact, HoyoWindow.GENSHIN_IMPACT_LAUNCHER),
            (ConfigRead.GetConfig(AppSettings.Settings.Default.HONKAI_STAR_RAIL_DIR), HoyoGames.HonkaiStarRail, HoyoWindow.HONKAI_STAR_RAIL_LAUNCHER),
            (ConfigRead.GetConfig(AppSettings.Settings.Default.HONKAI_IMPACT_THIRD_DIR), HoyoGames.HonkaiImpactThird, HoyoWindow.HONKAI_IMPACT_THIRD_LAUNCHER)
        };

        foreach(var (config, name, Launcher) in CollectionsMarshal.AsSpan(GameConfigs))
        {
            ValidateSettings(config, name, Launcher, out ErrorOccured, FirstRun);
            if(ErrorOccured) break;
        }

        if(!ErrorOccured)
            LastGame();
    }

    public static void GameChange(HoyoGames GameSelected, short uid)
    {
        ConfigRead GameConfig = ConfigRead.GetConfig(GameSelected.GAME_DIRECTORY);
        HoyoValues values = new(
            GameConfig.GameBackground,
            true,
            true,
            true,
            AppResources.Resources.GAME_DEFAULT_TEXT
        );

        if(GameSelected == HoyoGames.ZenlessZoneZero)
            values = new(
                new ImageBrush(new BitmapImage(new("pack://application:,,,/Resources/ZZZ.jpg", UriKind.RelativeOrAbsolute))),
                true,
                false,
                false,
                AppResources.Resources.GAME_SOON_TEXT
            );

        if(!GameConfig.ConfigExist)
        {
            MessageBox.Show($"ERROR:\nGame Executable not found!\n\nPlease Set the Location of the games first on the settings.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        HoyoChange.SetValues(values);
        
        CurrentGameSelected = GameSelected;
        ExecutableName = GameConfig.GameStartName;

        AppSettings.Settings.Default.LAST_GAME = uid += 1;
        AppSettings.Settings.Default.Save();
    }

    public static void ValidateSettings(ConfigRead GameConfig, HoyoGames Game, HoyoButton LauncherButton, out bool ErrorOccured, bool isNew = false)
    {
        ErrorOccured = false;

        if(GameConfig.FilePathNone)
        {
            LauncherButton.IsEnabled = false;
            return;
        }

        ErrorOccured = !GameConfig.ConfigExist || (Path.GetFileName(GameConfig.GameStartName) != Game.GAME_EXECUTABLE);

        if(!ErrorOccured)
        {
            LauncherButton.IsEnabled = true;
            return;
        }

        if(!isNew)
            MessageBox.Show($"ERROR:\n\nThe \"{Game.GAME_NAME}\" cannot be found!\n or its an incorrect game.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        
        LauncherButton.IsEnabled = false;
    }

    static void LastGame()
    {
        HoyoGames HG = null;
        short uid = AppSettings.Settings.Default.LAST_GAME;

        switch(uid)
        {
            case 1: HG = HoyoGames.GenshinImpact; break;
            case 2: HG = HoyoGames.HonkaiStarRail; break;
            case 3: HG = HoyoGames.HonkaiImpactThird; break;
        }

        if(HG is not null)
            GameChange(HG, uid -= 1);
    }
}