namespace SOHome.Common;

public class SOHomeDefaults
{
    public const string AppName = "SOHome";
    public const string AppVersion = "1.0.0";
    public const string AppDescription = "A simple recipe app";
    public const string AppAuthor = "Osni Pezzini Junior";
    public static readonly string UserConfigurationFolder = GetUserConfigurationFolder();
    public static readonly string SharedConfigurationFolder = GetSharedConfigurationFolder();

    private static string GetSharedConfigurationFolder()
    {
        return OperatingSystem.IsWindows()
            ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), AppName)
            : $"/etc/{AppName.ToLower()}";
    }

    private static string GetUserConfigurationFolder()
    {
        return OperatingSystem.IsWindows()
            ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppName)
            : $"~/.config/{AppName.ToLower()}";
    }
}