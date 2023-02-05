﻿using Library.Interfaces;
using Library.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace Library;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IHost? AppHost { get; private set; }

	public App()
	{
		AppHost = Host.CreateDefaultBuilder()
			.ConfigureServices((hostContext, services) =>
			{
				services.AddSingleton<MainWindow>();
				services.AddSingleton<AutorWindow>();
				services.AddTransient<IAutorService, AutorService>();
            })
			.Build();
	}

    protected override async void OnStartup(StartupEventArgs e)
    {
		await AppHost.StartAsync();

		var mainForm = AppHost.Services.GetRequiredService<MainWindow>();
		mainForm.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost.StopAsync();
        base.OnExit(e);
    }
}
