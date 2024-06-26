using Microsoft.Win32;

public static class Settings
{
    private const string RegistryPath = @"Software\CodingEnterprice\MusicMasterRadioDesktop";
    private const string LicenseAcceptedKey = "LicenseAccepted";

    public static bool LicenseAccepted
    {
        get
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath, false))
            {
                if (key == null) return false;
                object value = key.GetValue(LicenseAcceptedKey);
                return value != null && bool.Parse(value.ToString());
            }
        }
        set
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.SetValue(LicenseAcceptedKey, value);
            }
        }
    }

    public static void Uninstall()
    {
        try
        {
            Registry.CurrentUser.DeleteSubKeyTree(RegistryPath);
        }
        catch (System.ArgumentException SE)
        {
            System.Diagnostics.Debug.WriteLine(SE.Message);
        }
    }
}