﻿namespace HoyoLauncher;

// It was supposed to be a simple launcher that opens the game,
// why do i need to go as far as detecting a new version, downloading the new version and even pre-installing the upcoming version.
// what the fuck am i doing?

public partial class MainWindow : Window
{
    [StaticWindow]
    public static MainWindow HoyoWindow { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        Hide();

        HoyoWindow = this;

        HoyoMain.Initialize();

#if !DEBUG
        AppVersion.Text = App.IsPreview ? App.Version+" PREVIEW BUILD | NOT OFFICIAL VERSION" : App.Version;
#else
        AppVersion.Text += $": test ver({App.Version})";
#endif
        Debug.WriteLine("BUILD HASH: "+App.UniqueHashBUILD);
    }

    public static void SetProgressBarValue(double value) =>
        HoyoWindow.ProgressBarInner.Width = value / 100 * HoyoWindow.ProgressBarInner.MaxWidth;

    protected override void OnClosing(CancelEventArgs e)
    {
        e.Cancel = HoyoMain.IsGameRunning || RetrieveFile.IsDownloading;

        if (HoyoMain.IsGameRunning || App.Config.EXIT_MODE is 1 && !App.IsFromTray)
        {
            App.AppMinimizeToTray();
            e.Cancel = true;
        }
        else if (RetrieveFile.IsDownloading)
            HoyoMessageBox.Show("⚠️ Warning ⚠️", "Downloading Files! Cannot be closed.", HoyoWindow);
        else App.Config.SaveConfig();

        base.OnClosing(e);
    }

    private void MediaElement_OnMediaEnded(object s, RoutedEventArgs e)
    {
        MediaElement el = (MediaElement)s;
        
        el.Position = TimeSpan.Zero;
        el.Play();
    }
}