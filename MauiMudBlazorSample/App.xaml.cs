﻿
namespace MauiMudBlazorSample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();

        PlatformSpecificConfig.RunPlatformConfig();	

    }
}
