namespace HoyoLauncher.Core;

public sealed class HoyoMain
{
    public static bool FirstRun { get; set; }
    public static bool IsGameRunning { get; set; }
    public static string ExecutableName { get; set; }
    public static HoyoGames CurrentGameSelected { get; set; }

    public static void Initialize()
    {
        bool ErrorOccured = false;

        FirstRun = true;
        CurrentGameSelected = HoyoGames.DEFAULT;
        IsGameRunning = false;

        EventsAttribute.SetEvents();

        List<(ConfigRead config, HoyoGames AbsoluteName, HoyoLauncher_Controls.SideButtons.Button Launcher)> GameConfigs = new()
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

        if(!GameConfig.ConfigExist)
        {
            MessageBox.Show($"ERROR:\n\nGame Executable not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        HoyoWindow.HomeBG.Children.Remove(HoyoWindow.MainBG);
        HoyoWindow.HomeBG.Children.Remove(HoyoWindow.HoyoTitleIMG);

        if(GameSelected != HoyoGames.ZenlessZoneZero)
        {
            HoyoWindow.WINDOW_BORDER.Background = GameConfig.GameBackground;
            HoyoWindow.CheckInPage.IsEnabled = true;
            HoyoWindow.LaunchButton.IsEnabled = true;
            HoyoWindow.LaunchButton.Content = AppResources.Resources.GAME_DEFAULT_TEXT;
        }
        else
        {
            HoyoWindow.WINDOW_BORDER.Background = new ImageBrush(new BitmapImage(new("pack://application:,,,/Resources/ZZZ.jpg", UriKind.RelativeOrAbsolute)));
            HoyoWindow.CheckInPage.IsEnabled = false;
            HoyoWindow.LaunchButton.IsEnabled = false;
            HoyoWindow.LaunchButton.Content = AppResources.Resources.GAME_SOON_TEXT;
        }
        
        CurrentGameSelected = GameSelected;
        ExecutableName = GameConfig.GameStartName;

        AppSettings.Settings.Default.LAST_GAME = uid += 1;

        AppSettings.Settings.Default.Save();
    }

    public static void ValidateSettings(ConfigRead GameConfig, HoyoGames Game, HoyoLauncher_Controls.SideButtons.Button LauncherButton, out bool ErrorOccured, bool isNew = false)
    {
        ErrorOccured = false;

        if(GameConfig.FilePathNone)
        {
            LauncherButton.IsEnabled = false;
            return;
        }

        if(!GameConfig.ConfigExist)
            ErrorOccured = true;
        else
        {
            if(Path.GetFileName(GameConfig.GameStartName) != Game.GAME_EXECUTABLE)
                ErrorOccured = true;
        }

        if(ErrorOccured)
        {
            if(!isNew)
                MessageBox.Show($"ERROR:\n\nThe \"{Game.GAME_NAME}\" cannot be found!\n or its an incorrect game.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            
            LauncherButton.IsEnabled = false;
        }
        else LauncherButton.IsEnabled = true;
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