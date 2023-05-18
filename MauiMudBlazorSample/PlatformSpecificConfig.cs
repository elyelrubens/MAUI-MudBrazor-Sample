using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;


namespace MauiMudBlazorSample
{
    public class PlatformSpecificConfig
    {
        public static void RunPlatformConfig()
        {
            if (DeviceInfo.Current.Platform == DevicePlatform.Android)
            {
                //Ajust with show and hide keyboard
                Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
                
            }
        }
    }
}
